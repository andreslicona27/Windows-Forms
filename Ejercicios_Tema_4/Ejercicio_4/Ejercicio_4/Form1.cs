using System.Buffers;
using System.Collections;
using Timer = System.Windows.Forms.Timer;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Timer timer = new Timer();
        public int minTime = 0;
        public int secTime = 0;
        public Form1()
        {
            InitializeComponent();

            timer.Start();
            timer.Interval = (int)(1000);

            Text = String.Format("Claculator {0,2}:{1,2}", minTime, secTime);
            minTime++;
            if (minTime > 60)
            {
                minTime = 0;
                secTime++;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sure you want to close the program?", "My App",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
         == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            timer.Stop();
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


        private void tb_TextChanged(object sender, EventArgs e)
        {
            string number = ((TextBox)sender).Text.Trim();
            double result;
            if (double.TryParse(number, out result) || number.Equals(""))
            {
                ((TextBox)sender).BackColor = Color.White;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.Red;
            }
        }
    }
}