namespace TestComponent
{
    partial class Form1
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
            this.player1 = new Ejercicio_3.Player();
            this.cbFrecuency = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pbImages = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(214, 158);
            this.player1.Minutes = -120;
            this.player1.Name = "player1";
            this.player1.Seconds = 0;
            this.player1.Size = new System.Drawing.Size(172, 60);
            this.player1.TabIndex = 0;
            this.player1.PlayClick += new System.EventHandler(this.player1_PlayClick);
            this.player1.DesbordaTiempo += new System.EventHandler(this.player1_DesbordaTiempo);
            // 
            // cbFrecuency
            // 
            this.cbFrecuency.FormattingEnabled = true;
            this.cbFrecuency.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbFrecuency.Location = new System.Drawing.Point(12, 94);
            this.cbFrecuency.Name = "cbFrecuency";
            this.cbFrecuency.Size = new System.Drawing.Size(121, 21);
            this.cbFrecuency.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(9, 78);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(103, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time for each image";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 34);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(121, 23);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open Directory";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pbImages
            // 
            this.pbImages.Location = new System.Drawing.Point(214, 34);
            this.pbImages.Name = "pbImages";
            this.pbImages.Size = new System.Drawing.Size(172, 118);
            this.pbImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImages.TabIndex = 6;
            this.pbImages.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 236);
            this.Controls.Add(this.pbImages);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cbFrecuency);
            this.Controls.Add(this.player1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ejercicio_3.Player player1;
        private System.Windows.Forms.ComboBox cbFrecuency;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pbImages;
    }
}

