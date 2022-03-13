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
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly Parking<Excavator> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Excavator>(pictureBoxParking.Width,
            pictureBoxParking.Height);
            Draw();

        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }


        private void parkExcavatorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var excavator = new Excavator(100, 1000, dialog.Color);
            if (parking + excavator != -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void parkCleanerBtn_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var cleanerVehicle = new CleanerVehicle
                        (
                        100, 1000, dialog.Color, dialogDop.Color, true, true
                        );
                    if (parking + cleanerVehicle != -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        private void takeCarBtn_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var excavator = parking - Convert.ToInt32(maskedTextBox1.Text);
                if (excavator != null)
                {
                    FormCar form = new FormCar();
                    form.SetExcavator(excavator);
                    form.ShowDialog();
                }
                Draw();
            }

        }
    }
}
