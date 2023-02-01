namespace Ejercicio_1_Form
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
            this.btnPosicion = new System.Windows.Forms.Button();
            this.lbltxt1 = new Ejercicio_1.LabelTextbox();
            this.btnMoreSeparation = new System.Windows.Forms.Button();
            this.btnLessSeparation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPosicion
            // 
            this.btnPosicion.Location = new System.Drawing.Point(12, 59);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(75, 23);
            this.btnPosicion.TabIndex = 3;
            this.btnPosicion.Text = "Posicion";
            this.btnPosicion.UseVisualStyleBackColor = true;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // lbltxt1
            // 
            this.lbltxt1.Location = new System.Drawing.Point(12, 23);
            this.lbltxt1.Name = "lbltxt1";
            this.lbltxt1.Posicion = Ejercicio_1.ePosicion.IZQUIERDA;
            this.lbltxt1.PswChr = '\0';
            this.lbltxt1.Separacion = 20;
            this.lbltxt1.Size = new System.Drawing.Size(156, 20);
            this.lbltxt1.TabIndex = 2;
            this.lbltxt1.TextLbl = "HOLA";
            this.lbltxt1.TextTxt = "";
            this.lbltxt1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbltxt1_KeyUp);
            // 
            // btnMoreSeparation
            // 
            this.btnMoreSeparation.Location = new System.Drawing.Point(12, 88);
            this.btnMoreSeparation.Name = "btnMoreSeparation";
            this.btnMoreSeparation.Size = new System.Drawing.Size(37, 23);
            this.btnMoreSeparation.TabIndex = 4;
            this.btnMoreSeparation.Text = "+";
            this.btnMoreSeparation.UseVisualStyleBackColor = true;
            this.btnMoreSeparation.Click += new System.EventHandler(this.btnMoreSeparation_Click);
            // 
            // btnLessSeparation
            // 
            this.btnLessSeparation.Location = new System.Drawing.Point(50, 88);
            this.btnLessSeparation.Name = "btnLessSeparation";
            this.btnLessSeparation.Size = new System.Drawing.Size(37, 23);
            this.btnLessSeparation.TabIndex = 5;
            this.btnLessSeparation.Text = "-";
            this.btnLessSeparation.UseVisualStyleBackColor = true;
            this.btnLessSeparation.Click += new System.EventHandler(this.btnMoreSeparation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 197);
            this.Controls.Add(this.btnLessSeparation);
            this.Controls.Add(this.btnMoreSeparation);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.lbltxt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private Ejercicio_1.LabelTextbox lbltxt1;
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.Button btnMoreSeparation;
        private System.Windows.Forms.Button btnLessSeparation;
    }
}

