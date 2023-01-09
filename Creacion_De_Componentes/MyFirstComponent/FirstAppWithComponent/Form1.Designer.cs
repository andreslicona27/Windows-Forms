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
            this.SuspendLayout();
            // 
            // labelTextbox1
            // 
            this.labelTextbox1.Location = new System.Drawing.Point(12, 12);
            this.labelTextbox1.Name = "labelTextbox1";
            this.labelTextbox1.Posicion = MyFirstComponent.ePosicion.IZQUIERDA;
            this.labelTextbox1.Separacion = 0;
            this.labelTextbox1.Size = new System.Drawing.Size(342, 168);
            this.labelTextbox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 219);
            this.Controls.Add(this.labelTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyFirstComponent.LabelTextbox labelTextbox1;
    }
}

