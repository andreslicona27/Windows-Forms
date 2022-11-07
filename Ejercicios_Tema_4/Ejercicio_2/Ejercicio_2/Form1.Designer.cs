namespace Ejercicio_2
{
    partial class Ejericio_2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejericio_2));
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtbRojo = new System.Windows.Forms.TextBox();
            this.txtbAzul = new System.Windows.Forms.TextBox();
            this.txtbVerde = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtbRuta = new System.Windows.Forms.TextBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(367, 125);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 30);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.btnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseEnter);
            // 
            // txtbRojo
            // 
            this.txtbRojo.AcceptsTab = true;
            this.txtbRojo.Location = new System.Drawing.Point(128, 44);
            this.txtbRojo.Name = "txtbRojo";
            this.txtbRojo.Size = new System.Drawing.Size(70, 23);
            this.txtbRojo.TabIndex = 0;
            this.txtbRojo.CursorChanged += new System.EventHandler(this.txtbRojo_CursorChanged);
            // 
            // txtbAzul
            // 
            this.txtbAzul.Location = new System.Drawing.Point(276, 44);
            this.txtbAzul.Name = "txtbAzul";
            this.txtbAzul.Size = new System.Drawing.Size(70, 23);
            this.txtbAzul.TabIndex = 2;
            // 
            // txtbVerde
            // 
            this.txtbVerde.Location = new System.Drawing.Point(202, 44);
            this.txtbVerde.Name = "txtbVerde";
            this.txtbVerde.Size = new System.Drawing.Size(70, 23);
            this.txtbVerde.TabIndex = 1;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(367, 43);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(70, 30);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "COLOR";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            this.btnColor.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.btnColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseEnter);
            // 
            // txtbRuta
            // 
            this.txtbRuta.Location = new System.Drawing.Point(128, 84);
            this.txtbRuta.Name = "txtbRuta";
            this.txtbRuta.Size = new System.Drawing.Size(218, 23);
            this.txtbRuta.TabIndex = 4;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(367, 84);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(70, 30);
            this.btnImagen.TabIndex = 5;
            this.btnImagen.Text = "IMAGEN";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            this.btnImagen.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.btnImagen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Componentes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ruta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "B";
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.Location = new System.Drawing.Point(128, 113);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(218, 113);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 12;
            this.pb.TabStop = false;
            // 
            // Ejericio_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.txtbRuta);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txtbVerde);
            this.Controls.Add(this.txtbAzul);
            this.Controls.Add(this.txtbRojo);
            this.Controls.Add(this.btnSalir);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ejericio_2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalir;
        private TextBox txtbRojo;
        private TextBox txtbAzul;
        private TextBox txtbVerde;
        private Button btnColor;
        private TextBox txtbRuta;
        private Button btnImagen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pb;
    }
}