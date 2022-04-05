using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCars
{
    public partial class FormCarConfig : Form
    {
        Excavator excavator = null;

        private event Action<Excavator> eventAddCar;

        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(Action<Excavator> action)
        {
            if (eventAddCar == null)
            {
                eventAddCar = action;
            }
            else
            {
                eventAddCar += action;
            }
        }

        public FormCarConfig()
        {
            InitializeComponent();
            
            panelRed.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            cancelBtn.Click += (object sender, EventArgs e) => { Close(); };
        }

        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawExcavator()
        {
            if (excavator != null)
            {
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                excavator.SetPosition(140, 120, pictureBox.Width, pictureBox.Height);
                excavator.DrawTransport(gr);
                pictureBox.Image = bmp;
            }
        }

        private void labelExcavator_MouseDown(object sender, MouseEventArgs e)
        {
            labelExcavator.DoDragDrop(labelExcavator.Text, DragDropEffects.Move |
            DragDropEffects.Copy);

        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelCleanerV_MouseDown(object sender, MouseEventArgs e)
        {
            labelCleanerV.DoDragDrop(labelCleanerV.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Экскаватор":
                    excavator = new Excavator(100, 500, Color.White);
                    break;
                case "Уборщик":
                    excavator = new CleanerVehicle(100, 500, Color.White, Color.Black, false, false);
                    break;
            }
            DrawExcavator();
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Copy | DragDropEffects.Move);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelColor_DragDrop(object sender, DragEventArgs e)
        {
            if (excavator != null)
            {
                excavator.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawExcavator();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (excavator != null)
            {
                if (excavator is CleanerVehicle)
                {
                    (excavator as CleanerVehicle).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawExcavator();
                }

            }
        }

        /// <summary>
        /// Добавление машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            eventAddCar?.Invoke(excavator);
            Close();
        }

        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void checkBoxBackBrush_CheckedChanged(object sender, EventArgs e)
        {
            (excavator as CleanerVehicle).SetBackBrush(true);
            DrawExcavator();
        }

        private void checkBoxFrontScoop_CheckedChanged(object sender, EventArgs e)
        {
            (excavator as CleanerVehicle).SetFrontScoop(true);
            DrawExcavator();
        }
    }
}
