using System.Buffers;
using System.Collections;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using System.Xml.Linq;
using Timer = System.Windows.Forms.Timer;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        Dictionary<string, Operation> operationsTable = new Dictionary<string, Operation>();
        Timer timer = new Timer();
        public delegate void Operation(double number1, double number2);
        public int hourTime = 0;
        public int minTime = 0;
        public int secTime = 0;


        public Form1()
        {
            InitializeComponent();

            operationsTable.Add("+", (number1, number2) => lblResult.Text = "= " + (number1 + number2).ToString());
            operationsTable.Add("-", (number1, number2) => lblResult.Text = "= " + (number1 - number2).ToString());
            operationsTable.Add("*", (number1, number2) => lblResult.Text = "= " + (number1 * number2).ToString());
            operationsTable.Add("/", (number1, number2) => lblResult.Text = "= " + (number1 / number2).ToString());
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

        private void btnOperation_Click(object sender, EventArgs e)
        {
            bool var1 = double.TryParse(tbUno.Text, out double num1);
            bool var2 = double.TryParse(tbDos.Text, out double num2);
            bool evaluateNumber1 = tbUno.BackColor == Color.Red;
            bool evaluateNumber2 = tbDos.BackColor == Color.Red;

            if (evaluateNumber1 == true || evaluateNumber2 == true || tbUno.Text.Equals("") || tbDos.Text.Equals(""))
            {
                MessageBox.Show("You have to put numbers in both boxes", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                operationsTable[lblOperation.Text](num1, num2);

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (minTime == 60)
            {
                minTime = 0;
                hourTime++;
            }
            if (secTime == 60)
            {
                secTime = 0;
                minTime++;
            }
            Text = String.Format("Calculator  {0,2}:{1,2}:{2,2}", hourTime.ToString("D2"), minTime.ToString("D2"), secTime.ToString("D2"));
            secTime++;
        }


    }
}