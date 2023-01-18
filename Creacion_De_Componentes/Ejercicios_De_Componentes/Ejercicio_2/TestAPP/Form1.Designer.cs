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
            this.etiquetaAviso1 = new Ejercicio_2.EtiquetaAviso();
            this.etiquetaAviso2 = new Ejercicio_2.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso1.GFinal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.etiquetaAviso1.GInitial = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.etiquetaAviso1.Gradient = true;
            this.etiquetaAviso1.ImageMarca = global::TestAPP.Properties.Resources.animal;
            this.etiquetaAviso1.Location = new System.Drawing.Point(21, 35);
            this.etiquetaAviso1.Marca = Ejercicio_2.eMarca.ImagenMarca;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(172, 60);
            this.etiquetaAviso1.TabIndex = 2;
            this.etiquetaAviso1.Text = "Hola";
            this.etiquetaAviso1.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_ClickEnMarca);
            // 
            // etiquetaAviso2
            // 
            this.etiquetaAviso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso2.GFinal = System.Drawing.Color.PaleGreen;
            this.etiquetaAviso2.GInitial = System.Drawing.Color.Plum;
            this.etiquetaAviso2.Gradient = true;
            this.etiquetaAviso2.ImageMarca = null;
            this.etiquetaAviso2.Location = new System.Drawing.Point(21, 144);
            this.etiquetaAviso2.Marca = Ejercicio_2.eMarca.Cruz;
            this.etiquetaAviso2.Name = "etiquetaAviso2";
            this.etiquetaAviso2.Size = new System.Drawing.Size(76, 18);
            this.etiquetaAviso2.TabIndex = 1;
            this.etiquetaAviso2.Text = "Mensaje";
            this.etiquetaAviso2.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_ClickEnMarca);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etiquetaAviso1);
            this.Controls.Add(this.etiquetaAviso2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Ejercicio_2.EtiquetaAviso etiquetaAviso2;
        private Ejercicio_2.EtiquetaAviso etiquetaAviso1;
    }
}

