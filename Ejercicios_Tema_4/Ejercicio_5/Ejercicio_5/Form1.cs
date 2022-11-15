using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool varibleRepeated = false;
            foreach (var item in lbOne.Items)
            {
                if (item.ToString().Equals(tbElement.Text))
                {
                    varibleRepeated = true;
                }
            }
            if (!varibleRepeated)
            {
                lbOne.Items.Add(tbElement.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbElement.Text = lbOne.SelectedIndex.ToString();
            lbOne.Items.Remove(lbOne.SelectedIndex);
        }

        //lbOne.ClearSelected();
        private void btnTransferOne_Click(object sender, EventArgs e)
        {
            //lbTwo.Items.Add();
        }

        private void btnTransferTwo_Click(object sender, EventArgs e)
        {
            lbOne.Items.Add(lbTwo.SelectedIndex.ToString());
        }

        private int numberOfPoints = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 0;
            string title = "Ejercicio 5";
            int maxPoints = title.Length;

            Text = " " + new string(title[i], numberOfPoints);
            numberOfPoints = (numberOfPoints + 1) % (maxPoints + 1);
            i++;
        }

    }
}