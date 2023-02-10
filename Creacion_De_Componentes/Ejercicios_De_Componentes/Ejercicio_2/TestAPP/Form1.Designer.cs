namespace TestAPP
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
            this.ea = new Ejercicio_2.EtiquetaAviso();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ea
            // 
            this.ea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ea.GFinal = System.Drawing.Color.PaleGreen;
            this.ea.GInitial = System.Drawing.Color.Plum;
            this.ea.Gradient = true;
            this.ea.ImageMarca = null;
            this.ea.Location = new System.Drawing.Point(12, 12);
            this.ea.Marca = Ejercicio_2.eMarca.Cruz;
            this.ea.Name = "ea";
            this.ea.Size = new System.Drawing.Size(76, 18);
            this.ea.TabIndex = 1;
            this.ea.Text = "Mensaje";
            this.ea.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_ClickEnMarca);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(206, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 256);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Ejercicio_2.EtiquetaAviso ea;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

