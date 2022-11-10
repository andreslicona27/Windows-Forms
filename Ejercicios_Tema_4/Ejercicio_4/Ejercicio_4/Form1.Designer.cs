namespace Ejercicio_4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbUno = new System.Windows.Forms.TextBox();
            this.tbDos = new System.Windows.Forms.TextBox();
            this.btnOperation = new System.Windows.Forms.Button();
            this.rbAddition = new System.Windows.Forms.RadioButton();
            this.rbSubtraction = new System.Windows.Forms.RadioButton();
            this.rbMultiplication = new System.Windows.Forms.RadioButton();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUno
            // 
            this.tbUno.Location = new System.Drawing.Point(29, 31);
            this.tbUno.Name = "tbUno";
            this.tbUno.Size = new System.Drawing.Size(100, 23);
            this.tbUno.TabIndex = 0;
            this.tbUno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tvUno_KeyPress);
            // 
            // tbDos
            // 
            this.tbDos.Location = new System.Drawing.Point(156, 31);
            this.tbDos.Name = "tbDos";
            this.tbDos.Size = new System.Drawing.Size(100, 23);
            this.tbDos.TabIndex = 1;
            this.tbDos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tvUno_KeyPress);
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(156, 66);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(100, 69);
            this.btnOperation.TabIndex = 6;
            this.btnOperation.Text = "ENTER";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // rbAddition
            // 
            this.rbAddition.AutoSize = true;
            this.rbAddition.Location = new System.Drawing.Point(29, 66);
            this.rbAddition.Name = "rbAddition";
            this.rbAddition.Size = new System.Drawing.Size(33, 19);
            this.rbAddition.TabIndex = 2;
            this.rbAddition.TabStop = true;
            this.rbAddition.Text = "+";
            this.rbAddition.UseVisualStyleBackColor = true;
            this.rbAddition.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbSubtraction
            // 
            this.rbSubtraction.AutoSize = true;
            this.rbSubtraction.Location = new System.Drawing.Point(29, 105);
            this.rbSubtraction.Name = "rbSubtraction";
            this.rbSubtraction.Size = new System.Drawing.Size(30, 19);
            this.rbSubtraction.TabIndex = 4;
            this.rbSubtraction.TabStop = true;
            this.rbSubtraction.Text = "-";
            this.rbSubtraction.UseVisualStyleBackColor = true;
            this.rbSubtraction.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbMultiplication
            // 
            this.rbMultiplication.AutoSize = true;
            this.rbMultiplication.Location = new System.Drawing.Point(99, 66);
            this.rbMultiplication.Name = "rbMultiplication";
            this.rbMultiplication.Size = new System.Drawing.Size(30, 19);
            this.rbMultiplication.TabIndex = 3;
            this.rbMultiplication.TabStop = true;
            this.rbMultiplication.Text = "*";
            this.rbMultiplication.UseVisualStyleBackColor = true;
            this.rbMultiplication.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbDivision
            // 
            this.rbDivision.AutoSize = true;
            this.rbDivision.Location = new System.Drawing.Point(99, 105);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(30, 19);
            this.rbDivision.TabIndex = 5;
            this.rbDivision.TabStop = true;
            this.rbDivision.Text = "/";
            this.rbDivision.UseVisualStyleBackColor = true;
            this.rbDivision.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(135, 34);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(0, 15);
            this.lblOperation.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(262, 34);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(15, 15);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "=";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOperation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 156);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.rbDivision);
            this.Controls.Add(this.rbMultiplication);
            this.Controls.Add(this.rbSubtraction);
            this.Controls.Add(this.rbAddition);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.tbDos);
            this.Controls.Add(this.tbUno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbUno;
        private TextBox tbDos;
        private Button btnOperation;
        private RadioButton rbAddition;
        private RadioButton rbSubtraction;
        private RadioButton rbMultiplication;
        private RadioButton rbDivision;
        private Label lblOperation;
        private Label lblResult;
    }
}