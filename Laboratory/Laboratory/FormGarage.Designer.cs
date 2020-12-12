namespace Laboratory
{
    partial class FormGarages
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
            this.pictureBoxGarage = new System.Windows.Forms.PictureBox();
            this.buttonCreateTruck = new System.Windows.Forms.Button();
            this.groupBoxTake = new System.Windows.Forms.GroupBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxGarages = new System.Windows.Forms.ListBox();
            this.buttonAddGarage = new System.Windows.Forms.Button();
            this.labelGarageName = new System.Windows.Forms.Label();
            this.buttonRemoveGarage = new System.Windows.Forms.Button();
            this.groupBoxGarage = new System.Windows.Forms.GroupBox();
            this.textBoxGarageName = new System.Windows.Forms.TextBox();
            this.menuStripGarages = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarage)).BeginInit();
            this.groupBoxTake.SuspendLayout();
            this.groupBoxGarage.SuspendLayout();
            this.menuStripGarages.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxGarage
            // 
            this.pictureBoxGarage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxGarage.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxGarage.Name = "pictureBoxGarage";
            this.pictureBoxGarage.Size = new System.Drawing.Size(648, 470);
            this.pictureBoxGarage.TabIndex = 0;
            this.pictureBoxGarage.TabStop = false;
            // 
            // buttonCreateTruck
            // 
            this.buttonCreateTruck.Location = new System.Drawing.Point(668, 41);
            this.buttonCreateTruck.Name = "buttonCreateTruck";
            this.buttonCreateTruck.Size = new System.Drawing.Size(120, 42);
            this.buttonCreateTruck.TabIndex = 1;
            this.buttonCreateTruck.Text = "Создать грузовик";
            this.buttonCreateTruck.UseVisualStyleBackColor = true;
            this.buttonCreateTruck.Click += new System.EventHandler(this.buttonCreateTruck_Click);
            // 
            // groupBoxTake
            // 
            this.groupBoxTake.Controls.Add(this.buttonTake);
            this.groupBoxTake.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTake.Controls.Add(this.labelPlace);
            this.groupBoxTake.Location = new System.Drawing.Point(668, 101);
            this.groupBoxTake.Name = "groupBoxTake";
            this.groupBoxTake.Size = new System.Drawing.Size(120, 100);
            this.groupBoxTake.TabIndex = 2;
            this.groupBoxTake.TabStop = false;
            this.groupBoxTake.Text = "Забрать грузовик";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(6, 64);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(108, 30);
            this.buttonTake.TabIndex = 1;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(65, 29);
            this.maskedTextBoxPlace.Mask = "0";
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(49, 23);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(14, 32);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(45, 15);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // listBoxGarages
            // 
            this.listBoxGarages.FormattingEnabled = true;
            this.listBoxGarages.ItemHeight = 15;
            this.listBoxGarages.Location = new System.Drawing.Point(6, 175);
            this.listBoxGarages.Name = "listBoxGarages";
            this.listBoxGarages.Size = new System.Drawing.Size(108, 94);
            this.listBoxGarages.TabIndex = 3;
            this.listBoxGarages.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // buttonAddGarage
            // 
            this.buttonAddGarage.Location = new System.Drawing.Point(6, 66);
            this.buttonAddGarage.Name = "buttonAddGarage";
            this.buttonAddGarage.Size = new System.Drawing.Size(108, 30);
            this.buttonAddGarage.TabIndex = 1;
            this.buttonAddGarage.Text = "Добавить гараж";
            this.buttonAddGarage.UseVisualStyleBackColor = true;
            this.buttonAddGarage.Click += new System.EventHandler(this.buttonAddGarage_Click);
            // 
            // labelGarageName
            // 
            this.labelGarageName.AutoSize = true;
            this.labelGarageName.Location = new System.Drawing.Point(14, 19);
            this.labelGarageName.Name = "labelGarageName";
            this.labelGarageName.Size = new System.Drawing.Size(73, 15);
            this.labelGarageName.TabIndex = 0;
            this.labelGarageName.Text = "Имя гаража";
            // 
            // buttonRemoveGarage
            // 
            this.buttonRemoveGarage.Location = new System.Drawing.Point(6, 102);
            this.buttonRemoveGarage.Name = "buttonRemoveGarage";
            this.buttonRemoveGarage.Size = new System.Drawing.Size(108, 30);
            this.buttonRemoveGarage.TabIndex = 1;
            this.buttonRemoveGarage.Text = "Удалить гараж";
            this.buttonRemoveGarage.UseVisualStyleBackColor = true;
            this.buttonRemoveGarage.Click += new System.EventHandler(this.buttonRemoveGarage_Click);
            // 
            // groupBoxGarage
            // 
            this.groupBoxGarage.Controls.Add(this.buttonSort);
            this.groupBoxGarage.Controls.Add(this.textBoxGarageName);
            this.groupBoxGarage.Controls.Add(this.labelGarageName);
            this.groupBoxGarage.Controls.Add(this.buttonRemoveGarage);
            this.groupBoxGarage.Controls.Add(this.buttonAddGarage);
            this.groupBoxGarage.Controls.Add(this.listBoxGarages);
            this.groupBoxGarage.Location = new System.Drawing.Point(668, 207);
            this.groupBoxGarage.Name = "groupBoxGarage";
            this.groupBoxGarage.Size = new System.Drawing.Size(120, 275);
            this.groupBoxGarage.TabIndex = 4;
            this.groupBoxGarage.TabStop = false;
            this.groupBoxGarage.Text = "Гаражи";
            // 
            // textBoxGarageName
            // 
            this.textBoxGarageName.Location = new System.Drawing.Point(6, 37);
            this.textBoxGarageName.Name = "textBoxGarageName";
            this.textBoxGarageName.Size = new System.Drawing.Size(108, 23);
            this.textBoxGarageName.TabIndex = 4;
            // 
            // menuStripGarages
            // 
            this.menuStripGarages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile});
            this.menuStripGarages.Location = new System.Drawing.Point(0, 0);
            this.menuStripGarages.Name = "menuStripGarages";
            this.menuStripGarages.Size = new System.Drawing.Size(800, 24);
            this.menuStripGarages.TabIndex = 5;
            // 
            // menuItemFile
            // 
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(48, 20);
            this.menuItemFile.Text = "Файл";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(6, 138);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(108, 30);
            this.buttonSort.TabIndex = 5;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormGarages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.groupBoxGarage);
            this.Controls.Add(this.groupBoxTake);
            this.Controls.Add(this.buttonCreateTruck);
            this.Controls.Add(this.pictureBoxGarage);
            this.Controls.Add(this.menuStripGarages);
            this.MainMenuStrip = this.menuStripGarages;
            this.Name = "FormGarages";
            this.Text = "Форма с гаражами";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarage)).EndInit();
            this.groupBoxTake.ResumeLayout(false);
            this.groupBoxTake.PerformLayout();
            this.groupBoxGarage.ResumeLayout(false);
            this.groupBoxGarage.PerformLayout();
            this.menuStripGarages.ResumeLayout(false);
            this.menuStripGarages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGarage;
        private System.Windows.Forms.Button buttonCreateTruck;
        private System.Windows.Forms.GroupBox groupBoxTake;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.ListBox listBoxGarages;
        private System.Windows.Forms.Button buttonAddGarage;
        private System.Windows.Forms.Label labelGarageName;
        private System.Windows.Forms.Button buttonRemoveGarage;
        private System.Windows.Forms.GroupBox groupBoxGarage;
        private System.Windows.Forms.TextBox textBoxGarageName;
        private System.Windows.Forms.MenuStrip menuStripGarages;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.Button buttonSort;
    }
}