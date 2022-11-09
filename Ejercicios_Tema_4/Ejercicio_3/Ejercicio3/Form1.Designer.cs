namespace Ejercicio3
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
            this.btnImage = new System.Windows.Forms.Button();
            this.cbModal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(22, 24);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(136, 23);
            this.btnImage.TabIndex = 0;
            this.btnImage.Text = "New Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // cbModal
            // 
            this.cbModal.AutoSize = true;
            this.cbModal.Location = new System.Drawing.Point(179, 28);
            this.cbModal.Name = "cbModal";
            this.cbModal.Size = new System.Drawing.Size(60, 19);
            this.cbModal.TabIndex = 1;
            this.cbModal.Text = "Modal";
            this.cbModal.UseVisualStyleBackColor = true;
            this.cbModal.CheckStateChanged += new System.EventHandler(this.cbModal_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 75);
            this.Controls.Add(this.cbModal);
            this.Controls.Add(this.btnImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Picture Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnImage;
        private CheckBox cbModal;
    }
}