
namespace WindowsFormsCars
{
    partial class FormParking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.unparkCar = new System.Windows.Forms.GroupBox();
            this.takeCarBtn = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.textBoxParkings = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addParkingBtn = new System.Windows.Forms.Button();
            this.deleteParkingBtn = new System.Windows.Forms.Button();
            this.addVehicleBtn = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.unparkCar.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(9, 29);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(647, 426);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // unparkCar
            // 
            this.unparkCar.Controls.Add(this.takeCarBtn);
            this.unparkCar.Controls.Add(this.maskedTextBox1);
            this.unparkCar.Controls.Add(this.label1);
            this.unparkCar.Location = new System.Drawing.Point(665, 109);
            this.unparkCar.Name = "unparkCar";
            this.unparkCar.Size = new System.Drawing.Size(133, 121);
            this.unparkCar.TabIndex = 3;
            this.unparkCar.TabStop = false;
            this.unparkCar.Text = "Забрать машину";
            // 
            // takeCarBtn
            // 
            this.takeCarBtn.Location = new System.Drawing.Point(25, 74);
            this.takeCarBtn.Name = "takeCarBtn";
            this.takeCarBtn.Size = new System.Drawing.Size(75, 23);
            this.takeCarBtn.TabIndex = 2;
            this.takeCarBtn.Text = "Забрать";
            this.takeCarBtn.UseVisualStyleBackColor = true;
            this.takeCarBtn.Click += new System.EventHandler(this.takeCarBtn_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(70, 26);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место:";
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(666, 306);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(130, 95);
            this.listBoxParkings.TabIndex = 4;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged_1);
            // 
            // textBoxParkings
            // 
            this.textBoxParkings.Location = new System.Drawing.Point(662, 251);
            this.textBoxParkings.Name = "textBoxParkings";
            this.textBoxParkings.Size = new System.Drawing.Size(133, 20);
            this.textBoxParkings.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Парковки:";
            // 
            // addParkingBtn
            // 
            this.addParkingBtn.Location = new System.Drawing.Point(662, 277);
            this.addParkingBtn.Name = "addParkingBtn";
            this.addParkingBtn.Size = new System.Drawing.Size(133, 23);
            this.addParkingBtn.TabIndex = 7;
            this.addParkingBtn.Text = "Добавить парковку";
            this.addParkingBtn.UseVisualStyleBackColor = true;
            this.addParkingBtn.Click += new System.EventHandler(this.addParkingBtn_Click);
            // 
            // deleteParkingBtn
            // 
            this.deleteParkingBtn.Location = new System.Drawing.Point(666, 407);
            this.deleteParkingBtn.Name = "deleteParkingBtn";
            this.deleteParkingBtn.Size = new System.Drawing.Size(132, 23);
            this.deleteParkingBtn.TabIndex = 8;
            this.deleteParkingBtn.Text = "Удалить парковку";
            this.deleteParkingBtn.UseVisualStyleBackColor = true;
            this.deleteParkingBtn.Click += new System.EventHandler(this.deleteParkingBtn_Click_1);
            // 
            // addVehicleBtn
            // 
            this.addVehicleBtn.Location = new System.Drawing.Point(665, 29);
            this.addVehicleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addVehicleBtn.Name = "addVehicleBtn";
            this.addVehicleBtn.Size = new System.Drawing.Size(124, 75);
            this.addVehicleBtn.TabIndex = 9;
            this.addVehicleBtn.Text = "Добавить экскаватор";
            this.addVehicleBtn.UseVisualStyleBackColor = true;
            this.addVehicleBtn.Click += new System.EventHandler(this.addVehicleBtn_Click_1);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(798, 30);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.LoadToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.LoadToolStripMenuItem.Text = "Загрузить";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "\"Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "\"Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 462);
            this.Controls.Add(this.addVehicleBtn);
            this.Controls.Add(this.deleteParkingBtn);
            this.Controls.Add(this.addParkingBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxParkings);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.unparkCar);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.unparkCar.ResumeLayout(false);
            this.unparkCar.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox unparkCar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button takeCarBtn;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.TextBox textBoxParkings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addParkingBtn;
        private System.Windows.Forms.Button deleteParkingBtn;
        private System.Windows.Forms.Button addVehicleBtn;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}