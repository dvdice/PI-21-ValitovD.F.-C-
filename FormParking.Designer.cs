
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.unparkCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(16, 15);
            this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(863, 524);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // unparkCar
            // 
            this.unparkCar.Controls.Add(this.takeCarBtn);
            this.unparkCar.Controls.Add(this.maskedTextBox1);
            this.unparkCar.Controls.Add(this.label1);
            this.unparkCar.Location = new System.Drawing.Point(887, 148);
            this.unparkCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unparkCar.Name = "unparkCar";
            this.unparkCar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unparkCar.Size = new System.Drawing.Size(177, 149);
            this.unparkCar.TabIndex = 3;
            this.unparkCar.TabStop = false;
            this.unparkCar.Text = "Забрать машину";
            // 
            // takeCarBtn
            // 
            this.takeCarBtn.Location = new System.Drawing.Point(33, 91);
            this.takeCarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.takeCarBtn.Name = "takeCarBtn";
            this.takeCarBtn.Size = new System.Drawing.Size(100, 28);
            this.takeCarBtn.TabIndex = 2;
            this.takeCarBtn.Text = "Забрать";
            this.takeCarBtn.UseVisualStyleBackColor = true;
            this.takeCarBtn.Click += new System.EventHandler(this.takeCarBtn_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(93, 32);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(39, 22);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место:";
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.ItemHeight = 16;
            this.listBoxParkings.Location = new System.Drawing.Point(891, 390);
            this.listBoxParkings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(172, 116);
            this.listBoxParkings.TabIndex = 4;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged_1);
            // 
            // textBoxParkings
            // 
            this.textBoxParkings.Location = new System.Drawing.Point(887, 322);
            this.textBoxParkings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxParkings.Name = "textBoxParkings";
            this.textBoxParkings.Size = new System.Drawing.Size(176, 22);
            this.textBoxParkings.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(916, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Парковки:";
            // 
            // addParkingBtn
            // 
            this.addParkingBtn.Location = new System.Drawing.Point(887, 354);
            this.addParkingBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addParkingBtn.Name = "addParkingBtn";
            this.addParkingBtn.Size = new System.Drawing.Size(177, 28);
            this.addParkingBtn.TabIndex = 7;
            this.addParkingBtn.Text = "Добавить парковку";
            this.addParkingBtn.UseVisualStyleBackColor = true;
            this.addParkingBtn.Click += new System.EventHandler(this.addParkingBtn_Click);
            // 
            // deleteParkingBtn
            // 
            this.deleteParkingBtn.Location = new System.Drawing.Point(888, 510);
            this.deleteParkingBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteParkingBtn.Name = "deleteParkingBtn";
            this.deleteParkingBtn.Size = new System.Drawing.Size(176, 28);
            this.deleteParkingBtn.TabIndex = 8;
            this.deleteParkingBtn.Text = "Удалить парковку";
            this.deleteParkingBtn.UseVisualStyleBackColor = true;
            this.deleteParkingBtn.Click += new System.EventHandler(this.deleteParkingBtn_Click_1);
            // 
            // addVehicleBtn
            // 
            this.addVehicleBtn.Location = new System.Drawing.Point(898, 15);
            this.addVehicleBtn.Name = "addVehicleBtn";
            this.addVehicleBtn.Size = new System.Drawing.Size(165, 92);
            this.addVehicleBtn.TabIndex = 9;
            this.addVehicleBtn.Text = "Добавить экскаватор";
            this.addVehicleBtn.UseVisualStyleBackColor = true;
            this.addVehicleBtn.Click += new System.EventHandler(this.addVehicleBtn_Click_1);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 564);
            this.Controls.Add(this.addVehicleBtn);
            this.Controls.Add(this.deleteParkingBtn);
            this.Controls.Add(this.addParkingBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxParkings);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.unparkCar);
            this.Controls.Add(this.pictureBoxParking);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.unparkCar.ResumeLayout(false);
            this.unparkCar.PerformLayout();
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
    }
}