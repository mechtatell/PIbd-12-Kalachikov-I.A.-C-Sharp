namespace Laboratory
{
    partial class FormTruckCongif
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxHasSiren = new System.Windows.Forms.CheckBox();
            this.checkBoxHasTank = new System.Windows.Forms.CheckBox();
            this.checkBoxHasBumper = new System.Windows.Forms.CheckBox();
            this.checkBoxHasStrip = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.groupBoxBodyType = new System.Windows.Forms.GroupBox();
            this.labelTanker = new System.Windows.Forms.Label();
            this.labelTruck = new System.Windows.Forms.Label();
            this.panelTruck = new System.Windows.Forms.Panel();
            this.pictureBoxTruck = new System.Windows.Forms.PictureBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.labelOtherColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.groupBoxBodyType.SuspendLayout();
            this.panelTruck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTruck)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxHasSiren);
            this.groupBoxParameters.Controls.Add(this.checkBoxHasTank);
            this.groupBoxParameters.Controls.Add(this.checkBoxHasBumper);
            this.groupBoxParameters.Controls.Add(this.checkBoxHasStrip);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.labelWeight);
            this.groupBoxParameters.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 185);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(210, 110);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // checkBoxHasSiren
            // 
            this.checkBoxHasSiren.AutoSize = true;
            this.checkBoxHasSiren.Location = new System.Drawing.Point(120, 23);
            this.checkBoxHasSiren.Name = "checkBoxHasSiren";
            this.checkBoxHasSiren.Size = new System.Drawing.Size(67, 19);
            this.checkBoxHasSiren.TabIndex = 2;
            this.checkBoxHasSiren.Text = "Сирена";
            this.checkBoxHasSiren.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasTank
            // 
            this.checkBoxHasTank.AutoSize = true;
            this.checkBoxHasTank.Location = new System.Drawing.Point(120, 83);
            this.checkBoxHasTank.Name = "checkBoxHasTank";
            this.checkBoxHasTank.Size = new System.Drawing.Size(45, 19);
            this.checkBoxHasTank.TabIndex = 2;
            this.checkBoxHasTank.Text = "Бак";
            this.checkBoxHasTank.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasBumper
            // 
            this.checkBoxHasBumper.AutoSize = true;
            this.checkBoxHasBumper.Location = new System.Drawing.Point(120, 63);
            this.checkBoxHasBumper.Name = "checkBoxHasBumper";
            this.checkBoxHasBumper.Size = new System.Drawing.Size(68, 19);
            this.checkBoxHasBumper.TabIndex = 2;
            this.checkBoxHasBumper.Text = "Бампер";
            this.checkBoxHasBumper.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasStrip
            // 
            this.checkBoxHasStrip.AutoSize = true;
            this.checkBoxHasStrip.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxHasStrip.Location = new System.Drawing.Point(120, 43);
            this.checkBoxHasStrip.Name = "checkBoxHasStrip";
            this.checkBoxHasStrip.Size = new System.Drawing.Size(71, 19);
            this.checkBoxHasStrip.TabIndex = 2;
            this.checkBoxHasStrip.Text = "Полосы";
            this.checkBoxHasStrip.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(10, 76);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(92, 23);
            this.numericUpDownWeight.TabIndex = 1;
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(10, 35);
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(92, 23);
            this.numericUpDownMaxSpeed.TabIndex = 1;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(10, 61);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(53, 15);
            this.labelWeight.TabIndex = 0;
            this.labelWeight.Text = "Вес авто";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(10, 19);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(92, 15);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость";
            // 
            // groupBoxBodyType
            // 
            this.groupBoxBodyType.Controls.Add(this.labelTanker);
            this.groupBoxBodyType.Controls.Add(this.labelTruck);
            this.groupBoxBodyType.Location = new System.Drawing.Point(12, 9);
            this.groupBoxBodyType.Name = "groupBoxBodyType";
            this.groupBoxBodyType.Size = new System.Drawing.Size(210, 170);
            this.groupBoxBodyType.TabIndex = 0;
            this.groupBoxBodyType.TabStop = false;
            this.groupBoxBodyType.Text = "Тип кузова";
            // 
            // labelTanker
            // 
            this.labelTanker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTanker.Location = new System.Drawing.Point(10, 101);
            this.labelTanker.Name = "labelTanker";
            this.labelTanker.Size = new System.Drawing.Size(190, 55);
            this.labelTanker.TabIndex = 0;
            this.labelTanker.Text = "Бензовоз";
            this.labelTanker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTanker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTanker_MouseDown);
            // 
            // labelTruck
            // 
            this.labelTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTruck.Location = new System.Drawing.Point(10, 31);
            this.labelTruck.Name = "labelTruck";
            this.labelTruck.Size = new System.Drawing.Size(190, 55);
            this.labelTruck.TabIndex = 0;
            this.labelTruck.Text = "Грузовик";
            this.labelTruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTruck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTruck_MouseDown);
            // 
            // panelTruck
            // 
            this.panelTruck.AllowDrop = true;
            this.panelTruck.Controls.Add(this.pictureBoxTruck);
            this.panelTruck.Location = new System.Drawing.Point(238, 18);
            this.panelTruck.Name = "panelTruck";
            this.panelTruck.Size = new System.Drawing.Size(275, 147);
            this.panelTruck.TabIndex = 1;
            this.panelTruck.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTruck_DragDrop);
            this.panelTruck.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTruck_DragEnter);
            // 
            // pictureBoxTruck
            // 
            this.pictureBoxTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTruck.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTruck.Name = "pictureBoxTruck";
            this.pictureBoxTruck.Size = new System.Drawing.Size(275, 147);
            this.pictureBoxTruck.TabIndex = 0;
            this.pictureBoxTruck.TabStop = false;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.labelOtherColor);
            this.groupBoxColor.Controls.Add(this.labelMainColor);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Controls.Add(this.panelPurple);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelPink);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Location = new System.Drawing.Point(238, 185);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(275, 110);
            this.groupBoxColor.TabIndex = 0;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвет";
            // 
            // labelOtherColor
            // 
            this.labelOtherColor.AllowDrop = true;
            this.labelOtherColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOtherColor.Location = new System.Drawing.Point(10, 69);
            this.labelOtherColor.Name = "labelOtherColor";
            this.labelOtherColor.Size = new System.Drawing.Size(100, 30);
            this.labelOtherColor.TabIndex = 0;
            this.labelOtherColor.Text = "Доп. цвет";
            this.labelOtherColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOtherColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelOtherColor_DragDrop);
            this.labelOtherColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(10, 25);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(100, 30);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(127, 69);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(30, 30);
            this.panelBlack.TabIndex = 1;
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Magenta;
            this.panelPurple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPurple.Location = new System.Drawing.Point(199, 69);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(30, 30);
            this.panelPurple.TabIndex = 1;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(199, 25);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(30, 30);
            this.panelBlue.TabIndex = 1;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(163, 69);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(30, 30);
            this.panelGray.TabIndex = 1;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(235, 25);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(30, 30);
            this.panelWhite.TabIndex = 1;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Pink;
            this.panelPink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPink.Location = new System.Drawing.Point(235, 69);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(30, 30);
            this.panelPink.TabIndex = 1;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.ForestGreen;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(163, 25);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(30, 30);
            this.panelGreen.TabIndex = 1;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Crimson;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(127, 25);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(30, 30);
            this.panelRed.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(145, 305);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 30);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(275, 305);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 30);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormTruckCongif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 346);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelTruck);
            this.Controls.Add(this.groupBoxBodyType);
            this.Controls.Add(this.groupBoxParameters);
            this.Name = "FormTruckCongif";
            this.Text = "Выбор грузовика";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.groupBoxBodyType.ResumeLayout(false);
            this.panelTruck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTruck)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.GroupBox groupBoxBodyType;
        private System.Windows.Forms.Panel panelTruck;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxTruck;
        private System.Windows.Forms.CheckBox checkBoxHasTank;
        private System.Windows.Forms.CheckBox checkBoxHasBumper;
        private System.Windows.Forms.CheckBox checkBoxHasStrip;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.CheckBox checkBoxHasSiren;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Label labelOtherColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelTanker;
        private System.Windows.Forms.Label labelTruck;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}