using System.Buffers;
using System.Collections;
using Timer = System.Windows.Forms.Timer;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        Hashtable operationsTable = new Hashtable();
        Timer timer = new Timer();
        public delegate double Operation(double number1, double number2);
        public int hourTime = 0;
        public int minTime = 0;
        public int secTime = 0;
       

        public Form1()
        {
            InitializeComponent();

            //double number1 = double.Parse(tbUno.Text);
            //double number2 = double.Parse(tbDos.Text);

            operationsTable.Add("+", (Operation)((number1, number2) => number1 + number2));
            operationsTable.Add("-", (Operation)((number1, number2) => number1 - number2));
            operationsTable.Add("*", (Operation)((number1, number2) => number1 * number2));
            operationsTable.Add("/", (Operation)((number1, number2) => number1 / number2));
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
            try
            {
                //lblResult = String.Format("={0}", operationsTable[lblOperation.Text]);
               
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
            Text = String.Format("Calculator  {0,2}:{1,2}:{2,2}",hourTime.ToString("D2"), minTime.ToString("D2"), secTime.ToString("D2"));
            secTime++;
        }

        
    }
}