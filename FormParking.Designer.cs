
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
            this.parkExcavatorBtn = new System.Windows.Forms.Button();
            this.parkCleanerBtn = new System.Windows.Forms.Button();
            this.unparkCar = new System.Windows.Forms.GroupBox();
            this.takeCarBtn = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.unparkCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(647, 426);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // parkExcavatorBtn
            // 
            this.parkExcavatorBtn.Location = new System.Drawing.Point(665, 12);
            this.parkExcavatorBtn.Name = "parkExcavatorBtn";
            this.parkExcavatorBtn.Size = new System.Drawing.Size(123, 49);
            this.parkExcavatorBtn.TabIndex = 1;
            this.parkExcavatorBtn.Text = "Припарковать Экскаватор";
            this.parkExcavatorBtn.UseVisualStyleBackColor = true;
            this.parkExcavatorBtn.Click += new System.EventHandler(this.parkExcavatorBtn_Click);
            // 
            // parkCleanerBtn
            // 
            this.parkCleanerBtn.Location = new System.Drawing.Point(665, 67);
            this.parkCleanerBtn.Name = "parkCleanerBtn";
            this.parkCleanerBtn.Size = new System.Drawing.Size(124, 47);
            this.parkCleanerBtn.TabIndex = 2;
            this.parkCleanerBtn.Text = "Припарковать Уборщика";
            this.parkCleanerBtn.UseVisualStyleBackColor = true;
            this.parkCleanerBtn.Click += new System.EventHandler(this.parkCleanerBtn_Click);
            // 
            // unparkCar
            // 
            this.unparkCar.Controls.Add(this.takeCarBtn);
            this.unparkCar.Controls.Add(this.maskedTextBox1);
            this.unparkCar.Controls.Add(this.label1);
            this.unparkCar.Location = new System.Drawing.Point(665, 120);
            this.unparkCar.Name = "unparkCar";
            this.unparkCar.Size = new System.Drawing.Size(123, 121);
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
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unparkCar);
            this.Controls.Add(this.parkCleanerBtn);
            this.Controls.Add(this.parkExcavatorBtn);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.unparkCar.ResumeLayout(false);
            this.unparkCar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button parkExcavatorBtn;
        private System.Windows.Forms.Button parkCleanerBtn;
        private System.Windows.Forms.GroupBox unparkCar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button takeCarBtn;
    }
}