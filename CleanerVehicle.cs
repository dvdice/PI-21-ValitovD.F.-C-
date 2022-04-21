using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsCars
{
    public class CleanerVehicle : Excavator
    {
        public Color DopColor { private set; get; }
        public bool FrontScoop { private set; get; }
        public bool BackBrush { private set; get; }

        public CleanerVehicle(int maxSpeed, float weight, Color mainColor, Color dopColor, bool frontScoop, bool backBrush) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            FrontScoop = frontScoop;
            BackBrush = backBrush;
        }

        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public CleanerVehicle(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                BackBrush = Convert.ToBoolean(strs[4]);
                FrontScoop = Convert.ToBoolean(strs[5]);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            Brush grayBrush = new SolidBrush(Color.DarkGray);
            Brush mainBrush = new SolidBrush(MainColor);
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
            g.FillRectangle(mainBrush, _startPosX + 131, _startPosY - 65, 130, 30);
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
            g.FillRectangle(dopBrush, _startPosX + 217, _startPosY - 105, 40, 40);
            //щетка+крепеж
            if (BackBrush)
            {
                g.DrawLine(pen, _startPosX + 260, _startPosY - 40, _startPosX + 290, _startPosY - 25);
                g.DrawLine(pen, _startPosX + 260, _startPosY - 50, _startPosX + 290, _startPosY - 25);
                g.FillEllipse(greenBrush, _startPosX + 287, _startPosY - 30, 25, 25);
            }
        }
        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public void SetBackBrush(bool b)
        {
            BackBrush = b;
        }

        public void SetFrontScoop(bool b)
        {
            FrontScoop = b;
        }
        public override string ToString()
        {
            return
                $"{base.ToString()}{separator}{DopColor.Name}{separator}{FrontScoop}{separator}{BackBrush}{separator}";
        }
    }
}