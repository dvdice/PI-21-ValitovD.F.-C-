using System;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsCars
{
    public partial class FormCar : Form
    {
        private Excavator excavator;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormCar()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Метод отрисовки машины
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCars.Width, pictureBoxCars.Height);
            Graphics gr = Graphics.FromImage(bmp);
            excavator.DrawTransport(gr);
            pictureBoxCars.Image = bmp;
        }
 /// <summary>
 /// Обработка нажатия кнопки "Создать"
 /// </summary>
 /// <param name="sender"></param>
 /// <param name="e"></param>
 private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            excavator = new Excavator(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Yellow);
            excavator.SetPosition(rnd.Next(10, 100),
                                  rnd.Next(10, 100), 
                                  pictureBoxCars.Width,
                                  pictureBoxCars.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":

                    excavator.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    excavator.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    excavator.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    excavator.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            excavator = new Excavator(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Yellow);
            excavator.SetPosition(rnd.Next(10, 100),
                                  rnd.Next(10, 100),
                                  pictureBoxCars.Width,
                                  pictureBoxCars.Height);
            Draw();
        }

        private void buttonCreateCleaner_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            excavator = new CleanerVehicle(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
           Color.Yellow, true, true);
            excavator.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCars.Width,
           pictureBoxCars.Height);
            Draw();
        }
    }
}

