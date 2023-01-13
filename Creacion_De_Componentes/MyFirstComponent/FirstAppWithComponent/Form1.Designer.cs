namespace FirstAppWithComponent
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
            this.labelTextbox1 = new MyFirstComponent.LabelTextbox();
            this.etiquetaAviso1 = new MyFirstComponent.EtiquetaAviso();
            this.etiquetaAviso2 = new MyFirstComponent.EtiquetaAviso();
            this.etiquetaAviso3 = new MyFirstComponent.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // labelTextbox1
            // 
            this.labelTextbox1.Location = new System.Drawing.Point(12, 12);
            this.labelTextbox1.Name = "labelTextbox1";
            this.labelTextbox1.Posicion = MyFirstComponent.ePosicion.IZQUIERDA;
            this.labelTextbox1.Separacion = 0;
            this.labelTextbox1.Size = new System.Drawing.Size(342, 20);
            this.labelTextbox1.TabIndex = 0;
            this.labelTextbox1.TextLbl = "label1";
            this.labelTextbox1.TextTxt = "";
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.Location = new System.Drawing.Point(42, 133);
            this.etiquetaAviso1.Marca = MyFirstComponent.eMarca.Cruz;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(65, 15);
            this.etiquetaAviso1.TabIndex = 1;
            this.etiquetaAviso1.Text = "Mensaje";
            // 
            // etiquetaAviso2
            // 
            this.etiquetaAviso2.Location = new System.Drawing.Point(61, 99);
            this.etiquetaAviso2.Marca = MyFirstComponent.eMarca.Nada;
            this.etiquetaAviso2.Name = "etiquetaAviso2";
            this.etiquetaAviso2.Size = new System.Drawing.Size(46, 13);
            this.etiquetaAviso2.TabIndex = 2;
            this.etiquetaAviso2.Text = "Mensaje";
            // 
            // etiquetaAviso3
            // 
            this.etiquetaAviso3.Location = new System.Drawing.Point(12, 154);
            this.etiquetaAviso3.Marca = MyFirstComponent.eMarca.Circulo;
            this.etiquetaAviso3.Name = "etiquetaAviso3";
            this.etiquetaAviso3.Size = new System.Drawing.Size(99, 53);
            this.etiquetaAviso3.TabIndex = 3;
            this.etiquetaAviso3.Text = "Mensaje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 219);
            this.Controls.Add(this.etiquetaAviso3);
            this.Controls.Add(this.etiquetaAviso2);
            this.Controls.Add(this.etiquetaAviso1);
            this.Controls.Add(this.labelTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyFirstComponent.LabelTextbox labelTextbox1;
        private MyFirstComponent.EtiquetaAviso etiquetaAviso1;
        private MyFirstComponent.EtiquetaAviso etiquetaAviso2;
        private MyFirstComponent.EtiquetaAviso etiquetaAviso3;
    }
}

