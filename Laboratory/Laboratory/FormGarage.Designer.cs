namespace Laboratory
{
    partial class FormGarage
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
            this.buttonCreateTanker = new System.Windows.Forms.Button();
            this.groupBoxTake = new System.Windows.Forms.GroupBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarage)).BeginInit();
            this.groupBoxTake.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxGarage
            // 
            this.pictureBoxGarage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxGarage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGarage.Name = "pictureBoxGarage";
            this.pictureBoxGarage.Size = new System.Drawing.Size(648, 450);
            this.pictureBoxGarage.TabIndex = 0;
            this.pictureBoxGarage.TabStop = false;
            // 
            // buttonCreateTruck
            // 
            this.buttonCreateTruck.Location = new System.Drawing.Point(668, 12);
            this.buttonCreateTruck.Name = "buttonCreateTruck";
            this.buttonCreateTruck.Size = new System.Drawing.Size(120, 40);
            this.buttonCreateTruck.TabIndex = 1;
            this.buttonCreateTruck.Text = "Создать грузовик";
            this.buttonCreateTruck.UseVisualStyleBackColor = true;
            this.buttonCreateTruck.Click += new System.EventHandler(this.buttonCreateTruck_Click);
            // 
            // buttonCreateTanker
            // 
            this.buttonCreateTanker.Location = new System.Drawing.Point(668, 58);
            this.buttonCreateTanker.Name = "buttonCreateTanker";
            this.buttonCreateTanker.Size = new System.Drawing.Size(120, 40);
            this.buttonCreateTanker.TabIndex = 1;
            this.buttonCreateTanker.Text = "Создать бензовоз";
            this.buttonCreateTanker.UseVisualStyleBackColor = true;
            this.buttonCreateTanker.Click += new System.EventHandler(this.buttonCreateTanker_Click);
            // 
            // groupBoxTake
            // 
            this.groupBoxTake.Controls.Add(this.buttonTake);
            this.groupBoxTake.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTake.Controls.Add(this.labelPlace);
            this.groupBoxTake.Location = new System.Drawing.Point(668, 104);
            this.groupBoxTake.Name = "groupBoxTake";
            this.groupBoxTake.Size = new System.Drawing.Size(120, 100);
            this.groupBoxTake.TabIndex = 2;
            this.groupBoxTake.TabStop = false;
            this.groupBoxTake.Text = "Забрать грузовик";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(14, 58);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(100, 30);
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
            // FormGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTake);
            this.Controls.Add(this.buttonCreateTanker);
            this.Controls.Add(this.buttonCreateTruck);
            this.Controls.Add(this.pictureBoxGarage);
            this.Name = "FormGarage";
            this.Text = "FormGarage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarage)).EndInit();
            this.groupBoxTake.ResumeLayout(false);
            this.groupBoxTake.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGarage;
        private System.Windows.Forms.Button buttonCreateTruck;
        private System.Windows.Forms.Button buttonCreateTanker;
        private System.Windows.Forms.GroupBox groupBoxTake;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
    }
}