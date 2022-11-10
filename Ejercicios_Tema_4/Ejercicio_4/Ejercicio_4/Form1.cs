using System.Buffers;
using System.Collections;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sure you want to close the program?", "My App",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
         == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            lblOperation.Text = ((RadioButton)sender).Text;
        }

        public delegate double Operation(double number1, double number2);
        Operation add = (number1, number2) => number1 + number2;
        Operation subtract = (number1, number2) => number1 - number2;
        Operation multiply = (number1, number2) => number1 * number2;
        Operation divide = (number1, number2) => number1 / number2;

        Hashtable operationsTable = new Hashtable();


        private void btnOperation_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(tbUno.Text);
            double number2 = double.Parse(tbDos.Text);

            operationsTable.Add("+", add);
            operationsTable.Add("-", subtract);
            operationsTable.Add("*", multiply);
            operationsTable.Add("/", divide);

            try
            {
                if (rbAddition.Checked)
                {
                    
                }
            }
            catch (FormatException)
            {

            }


        }

        private void tvUno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                ((TextBox)sender).BackColor = Color.Red;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.White;
            }
        }
    }
}