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
            this.etiquetaAviso2 = new Ejercicio_2.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // etiquetaAviso2
            // 
            this.etiquetaAviso2.GFinal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.etiquetaAviso2.GInitial = System.Drawing.Color.Red;
            this.etiquetaAviso2.Gradient = true;
            this.etiquetaAviso2.Location = new System.Drawing.Point(12, 12);
            this.etiquetaAviso2.Marca = Ejercicio_2.eMarca.Circulo;
            this.etiquetaAviso2.Name = "etiquetaAviso2";
            this.etiquetaAviso2.Size = new System.Drawing.Size(131, 53);
            this.etiquetaAviso2.TabIndex = 1;
            this.etiquetaAviso2.Text = "etiquetaAviso2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etiquetaAviso2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Ejercicio_2.EtiquetaAviso etiquetaAviso2;
    }
}

