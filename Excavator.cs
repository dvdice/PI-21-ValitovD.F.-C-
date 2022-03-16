using System.Drawing;

namespace WindowsFormsCars
{
    /// <summary>
    /// Класс отрисовки автомобиля
    /// </summary>
    public class Excavator
    {
        /// <summary>
        /// Левая координата отрисовки автомобиля
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки автомобиля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private readonly int excavatorWidth = 110;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        private readonly int excavatorHeight = 60;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего ковша
        /// </summary>
        public bool FrontScoop { private set; get; }
        /// <summary>
        /// Признак наличия задней щетки
        /// </summary>
        public bool BackBrush { private set; get; }


        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontScoop">Признак наличия переднего ковша</param>
        /// <param name="backBrush">Признак наличия задней щетки</param>
        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool frontScoop, bool backBrush)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FrontScoop = frontScoop;
            BackBrush = backBrush;
        }
        /// <summary>
        /// Установка позиции экскаватора
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            // Продумать логику
            _startPosX = x;
            _startPosY = y + 100;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (BackBrush)
                    {
                        if (_startPosX + step < _pictureWidth - excavatorWidth - 205)
                        {
                            _startPosX += step;
                        }
                    }
                    else
                    {
                        if (_startPosX + step < _pictureWidth - excavatorWidth - 150)
                        {
                            _startPosX += step;
                        }
                    }
                    
                    break;
                //влево
                case Direction.Left:
                    if (FrontScoop)
                    {
                        if (_startPosX > 2)
                        {
                            _startPosX -= step;
                        }
                    }
                    else
                    {
                        if (_startPosX > -100)
                        {
                            _startPosX -= step;
                        }
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY > 100)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - excavatorHeight + 72)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush blueBrush = new SolidBrush(Color.Blue);
            Brush grayBrush = new SolidBrush(Color.DarkGray);
            Brush yellowBrush = new SolidBrush(Color.Yellow);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush greenBrush = new SolidBrush(Color.Green);

            // передний ковш 
            if (FrontScoop)
            {
                //ковш
                g.DrawLine(pen, _startPosX, _startPosY, _startPosX + 80, _startPosY - 40);
                g.DrawLine(pen, _startPosX + 10, _startPosY - 5, _startPosX + 70, _startPosY - 5);
                g.DrawLine(pen, _startPosX + 70, _startPosY - 5, _startPosX + 100, _startPosY - 15);
                g.DrawLine(pen, _startPosX + 100, _startPosY - 15, _startPosX + 80, _startPosY - 40);
                //крепление
                g.DrawLine(pen, _startPosX + 88, _startPosY - 31, _startPosX + 130, _startPosY - 50);
                g.DrawLine(pen, _startPosX + 94, _startPosY - 25, _startPosX + 130, _startPosY - 40);
            }
            //кузов
            g.FillRectangle(yellowBrush, _startPosX + 130, _startPosY - 65, 130, 30);
            //гусеницы
            g.FillEllipse(grayBrush, _startPosX + 115, _startPosY - 35, 60, 30);
            g.FillEllipse(grayBrush, _startPosX + 130, _startPosY - 35, 60, 30);
            g.FillEllipse(grayBrush, _startPosX + 150, _startPosY - 35, 60, 30);
            g.FillEllipse(grayBrush, _startPosX + 170, _startPosY - 35, 60, 30);
            g.FillEllipse(grayBrush, _startPosX + 190, _startPosY - 35, 60, 30);
            g.FillEllipse(grayBrush, _startPosX + 210, _startPosY - 35, 60, 30);
            //колесики
            g.FillEllipse(blackBrush, _startPosX + 120, _startPosY - 32, 25, 25);
            g.FillEllipse(blackBrush, _startPosX + 240, _startPosY - 32, 25, 25);
            g.FillEllipse(blackBrush, _startPosX + 150, _startPosY - 23, 15, 15);
            g.FillEllipse(blackBrush, _startPosX + 167, _startPosY - 23, 15, 15);
            g.FillEllipse(blackBrush, _startPosX + 184, _startPosY - 23, 15, 15);
            g.FillEllipse(blackBrush, _startPosX + 201, _startPosY - 23, 15, 15);
            g.FillEllipse(blackBrush, _startPosX + 218, _startPosY - 23, 15, 15);
            //труба
            g.FillRectangle(blackBrush, _startPosX + 160, _startPosY - 95, 10, 30);
            //кабина
            g.FillRectangle(blueBrush, _startPosX + 217, _startPosY - 105, 40, 40);
            //щетка+крепеж
            if (BackBrush)
            {
                g.DrawLine(pen, _startPosX + 260, _startPosY - 40, _startPosX + 290, _startPosY - 25);
                g.DrawLine(pen, _startPosX + 260, _startPosY - 50, _startPosX + 290, _startPosY - 25);
                g.FillEllipse(greenBrush, _startPosX + 287, _startPosY - 30, 25, 25);
            }
        }
    }
}