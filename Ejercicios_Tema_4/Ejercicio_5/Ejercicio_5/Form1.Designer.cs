namespace Ejercicio_5
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
            this.components = new System.ComponentModel.Container();
            this.lbOne = new System.Windows.Forms.ListBox();
            this.lbTwo = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTransferTwo = new System.Windows.Forms.Button();
            this.btnTransferOne = new System.Windows.Forms.Button();
            this.lblNumElements = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.tbElement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerText = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbOne
            // 
            this.lbOne.FormattingEnabled = true;
            this.lbOne.ItemHeight = 15;
            this.lbOne.Location = new System.Drawing.Point(190, 33);
            this.lbOne.Name = "lbOne";
            this.lbOne.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbOne.Size = new System.Drawing.Size(120, 199);
            this.lbOne.TabIndex = 0;
            this.lbOne.SelectedIndexChanged += new System.EventHandler(this.lbOne_SelectedIndexChanged);
            // 
            // lbTwo
            // 
            this.lbTwo.FormattingEnabled = true;
            this.lbTwo.ItemHeight = 15;
            this.lbTwo.Location = new System.Drawing.Point(327, 33);
            this.lbTwo.Name = "lbTwo";
            this.lbTwo.Size = new System.Drawing.Size(120, 199);
            this.lbTwo.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(23, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTransferTwo
            // 
            this.btnTransferTwo.Location = new System.Drawing.Point(24, 207);
            this.btnTransferTwo.Name = "btnTransferTwo";
            this.btnTransferTwo.Size = new System.Drawing.Size(138, 23);
            this.btnTransferTwo.TabIndex = 5;
            this.btnTransferTwo.Text = "Transfer to List One";
            this.btnTransferTwo.UseVisualStyleBackColor = true;
            this.btnTransferTwo.Click += new System.EventHandler(this.btnTransferTwo_Click);
            // 
            // btnTransferOne
            // 
            this.btnTransferOne.Location = new System.Drawing.Point(23, 177);
            this.btnTransferOne.Name = "btnTransferOne";
            this.btnTransferOne.Size = new System.Drawing.Size(138, 23);
            this.btnTransferOne.TabIndex = 4;
            this.btnTransferOne.Text = "Transfer to List Two";
            this.btnTransferOne.UseVisualStyleBackColor = true;
            this.btnTransferOne.Click += new System.EventHandler(this.btnTransferOne_Click);
            // 
            // lblNumElements
            // 
            this.lblNumElements.AutoSize = true;
            this.lblNumElements.Location = new System.Drawing.Point(23, 33);
            this.lblNumElements.Name = "lblNumElements";
            this.lblNumElements.Size = new System.Drawing.Size(79, 15);
            this.lblNumElements.TabIndex = 0;
            this.lblNumElements.Text = "Elts in list one";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(23, 62);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(96, 15);
            this.lblIndex.TabIndex = 0;
            this.lblIndex.Text = "Index of element";
            // 
            // tbElement
            // 
            this.tbElement.Location = new System.Drawing.Point(23, 90);
            this.tbElement.Name = "tbElement";
            this.tbElement.Size = new System.Drawing.Size(138, 23);
            this.tbElement.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "List One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "List Two";
            // 
            // timerText
            // 
            this.timerText.Enabled = true;
            this.timerText.Interval = 200;
            this.timerText.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 254);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbElement);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblNumElements);
            this.Controls.Add(this.btnTransferTwo);
            this.Controls.Add(this.btnTransferOne);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbTwo);
            this.Controls.Add(this.lbOne);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbOne;
        private ListBox lbTwo;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnTransferTwo;
        private Button btnTransferOne;
        private Label lblNumElements;
        private Label lblIndex;
        private TextBox tbElement;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timerText;
    }
}