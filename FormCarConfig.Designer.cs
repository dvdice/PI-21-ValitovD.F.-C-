
namespace WindowsFormsCars
{
    partial class FormCarConfig
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
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.checkBoxFrontScoop = new System.Windows.Forms.CheckBox();
            this.checkBoxBackBrush = new System.Windows.Forms.CheckBox();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxTypeOfBody = new System.Windows.Forms.GroupBox();
            this.labelCleanerV = new System.Windows.Forms.Label();
            this.labelExcavator = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBoxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxTypeOfBody.SuspendLayout();
            this.panel.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.checkBoxFrontScoop);
            this.groupBoxParams.Controls.Add(this.checkBoxBackBrush);
            this.groupBoxParams.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParams.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParams.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParams.Controls.Add(this.labelWeight);
            this.groupBoxParams.Location = new System.Drawing.Point(9, 261);
            this.groupBoxParams.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxParams.Size = new System.Drawing.Size(331, 110);
            this.groupBoxParams.TabIndex = 0;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры";
            // 
            // checkBoxFrontScoop
            // 
            this.checkBoxFrontScoop.AutoSize = true;
            this.checkBoxFrontScoop.Location = new System.Drawing.Point(185, 76);
            this.checkBoxFrontScoop.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxFrontScoop.Name = "checkBoxFrontScoop";
            this.checkBoxFrontScoop.Size = new System.Drawing.Size(119, 19);
            this.checkBoxFrontScoop.TabIndex = 5;
            this.checkBoxFrontScoop.Text = "Передний ковш";
            this.checkBoxFrontScoop.UseVisualStyleBackColor = true;
            this.checkBoxFrontScoop.CheckedChanged += new System.EventHandler(this.checkBoxFrontScoop_CheckedChanged);
            // 
            // checkBoxBackBrush
            // 
            this.checkBoxBackBrush.AutoSize = true;
            this.checkBoxBackBrush.Location = new System.Drawing.Point(185, 39);
            this.checkBoxBackBrush.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBackBrush.Name = "checkBoxBackBrush";
            this.checkBoxBackBrush.Size = new System.Drawing.Size(111, 19);
            this.checkBoxBackBrush.TabIndex = 4;
            this.checkBoxBackBrush.Text = "Задняя щетка";
            this.checkBoxBackBrush.UseVisualStyleBackColor = true;
            this.checkBoxBackBrush.CheckedChanged += new System.EventHandler(this.checkBoxBackBrush_CheckedChanged);
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(20, 76);
            this.numericUpDownMaxSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownMaxSpeed.TabIndex = 3;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(20, 39);
            this.numericUpDownWeight.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownWeight.TabIndex = 2;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(4, 59);
            this.labelMaxSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(151, 15);
            this.labelMaxSpeed.TabIndex = 1;
            this.labelMaxSpeed.Text = "Максимальная скорость";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(7, 23);
            this.labelWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(104, 15);
            this.labelWeight.TabIndex = 0;
            this.labelWeight.Text = "Вес экскаватора";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(2, 7);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(336, 234);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // groupBoxTypeOfBody
            // 
            this.groupBoxTypeOfBody.Controls.Add(this.labelCleanerV);
            this.groupBoxTypeOfBody.Controls.Add(this.labelExcavator);
            this.groupBoxTypeOfBody.Location = new System.Drawing.Point(9, 2);
            this.groupBoxTypeOfBody.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTypeOfBody.Name = "groupBoxTypeOfBody";
            this.groupBoxTypeOfBody.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTypeOfBody.Size = new System.Drawing.Size(130, 177);
            this.groupBoxTypeOfBody.TabIndex = 7;
            this.groupBoxTypeOfBody.TabStop = false;
            this.groupBoxTypeOfBody.Text = "Тип кузова";
            // 
            // labelCleanerV
            // 
            this.labelCleanerV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCleanerV.Location = new System.Drawing.Point(8, 97);
            this.labelCleanerV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCleanerV.Name = "labelCleanerV";
            this.labelCleanerV.Size = new System.Drawing.Size(116, 48);
            this.labelCleanerV.TabIndex = 9;
            this.labelCleanerV.Text = "Уборщик";
            this.labelCleanerV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCleanerV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCleanerV_MouseDown);
            // 
            // labelExcavator
            // 
            this.labelExcavator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelExcavator.Location = new System.Drawing.Point(10, 34);
            this.labelExcavator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExcavator.Name = "labelExcavator";
            this.labelExcavator.Size = new System.Drawing.Size(116, 48);
            this.labelExcavator.TabIndex = 8;
            this.labelExcavator.Text = "Экскаватор";
            this.labelExcavator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExcavator.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelExcavator_MouseDown);
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(144, 10);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(344, 247);
            this.panel.TabIndex = 8;
            this.panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelColor);
            this.groupBoxColors.Location = new System.Drawing.Point(492, 10);
            this.groupBoxColors.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxColors.Size = new System.Drawing.Size(264, 166);
            this.groupBoxColors.TabIndex = 9;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(207, 115);
            this.panelGray.Margin = new System.Windows.Forms.Padding(2);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(29, 31);
            this.panelGray.TabIndex = 8;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(207, 67);
            this.panelWhite.Margin = new System.Windows.Forms.Padding(2);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(29, 31);
            this.panelWhite.TabIndex = 7;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(19, 115);
            this.panelGreen.Margin = new System.Windows.Forms.Padding(2);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(29, 31);
            this.panelGreen.TabIndex = 5;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(138, 115);
            this.panelBlack.Margin = new System.Windows.Forms.Padding(2);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(29, 31);
            this.panelBlack.TabIndex = 6;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(138, 67);
            this.panelBlue.Margin = new System.Windows.Forms.Padding(2);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(29, 31);
            this.panelBlue.TabIndex = 5;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(80, 67);
            this.panelYellow.Margin = new System.Windows.Forms.Padding(2);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(29, 31);
            this.panelYellow.TabIndex = 4;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(80, 115);
            this.panelOrange.Margin = new System.Windows.Forms.Padding(2);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(29, 31);
            this.panelOrange.TabIndex = 3;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(19, 67);
            this.panelRed.Margin = new System.Windows.Forms.Padding(2);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(29, 31);
            this.panelRed.TabIndex = 2;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(138, 15);
            this.labelDopColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(122, 39);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // labelColor
            // 
            this.labelColor.AllowDrop = true;
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColor.Location = new System.Drawing.Point(4, 15);
            this.labelColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(130, 39);
            this.labelColor.TabIndex = 0;
            this.labelColor.Text = "Основной цвет";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelColor_DragDrop);
            this.labelColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(625, 292);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(92, 33);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(533, 251);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(93, 37);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 382);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBoxTypeOfBody);
            this.Controls.Add(this.groupBoxParams);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCarConfig";
            this.Text = "Выбор машины";
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxTypeOfBody.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.CheckBox checkBoxFrontScoop;
        private System.Windows.Forms.CheckBox checkBoxBackBrush;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBoxTypeOfBody;
        private System.Windows.Forms.Label labelCleanerV;
        private System.Windows.Forms.Label labelExcavator;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}