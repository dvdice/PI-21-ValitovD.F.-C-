﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    class Parking<T> where T : class, ITransport
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly List<T> _places;
        /// <summary>
        /// Максимальное количество мест на парковке
        /// </summary>
        private readonly int _maxCount;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 320;//280
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 130;//130

        protected readonly int excavatorWidth = 60;
        protected readonly int excavatorHeight = 60;

        private int width;
        private int height;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер парковки - ширина</param>
        /// <param name="picHeight">Рамзер парковки - высота</param>
        public Parking(int picWidth, int picHeight)
        {
            width = picWidth / _placeSizeWidth;
            height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            _places = new List<T>();
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        private bool CheckForFreePlace(int index)
        {
            return _places[index] == null;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется автомобиль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="car">Добавляемый автомобиль</param>
        /// <returns></returns>
        public static bool operator +(Parking<T> p, T excavator)
        {
            if (p._places.Count >= p._maxCount)
            {
                return false;
            }
            else
            {
                p._places.Add(excavator);
                return true;
            }
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем автомобиль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        /// <returns></returns>
        public static T operator -(Parking<T> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                return null;
            }
            else
            {
                T delete = p._places[index];
                p._places.RemoveAt(index);
                return delete;
            }
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(135 + i % 2 * _placeSizeWidth, i / 2 * _placeSizeHeight + 75, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
        {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    //линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth/2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}