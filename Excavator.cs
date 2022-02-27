using System.Drawing;

namespace WindowsFormsCars
{
    /// <summary>
    /// Класс отрисовки автомобиля
    /// </summary>
    public class Excavator : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private readonly int excavatorWidth = 100;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        private readonly int excavatorHeight = 60;

        protected Excavator(int maxSpeed, float weight, Color mainColor, int excavatorWidth, int excavatorHeight)
        {
            MainColor = mainColor;
            MaxSpeed = maxSpeed;
            Weight = weight;
            this.excavatorHeight = excavatorHeight;
            this.excavatorWidth = excavatorWidth;
        }
        public Excavator(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - excavatorWidth - 205)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX > 2)
                    {
                        _startPosX -= step;
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
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush blueBrush = new SolidBrush(Color.Blue);
            Brush grayBrush = new SolidBrush(Color.DarkGray);
            Brush yellowBrush = new SolidBrush(Color.Yellow);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush greenBrush = new SolidBrush(Color.Green);

            
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
            
        }
    }
}