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
                lblNumElements.Text = "Elts in list one: " + lbOne.Items.Count;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                do
                {
                    lbOne.Items.RemoveAt(lbOne.SelectedIndex);
                } while (lbOne.SelectedIndex > -1);

                lblNumElements.Text = "Elts in list one: " + lbOne.Items.Count;

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Try to selected an element before deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //lbOne.ClearSelected();
        private void btnTransferOne_Click(object sender, EventArgs e)
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
                lbTwo.Items.Add(lbOne.SelectedItem);
                //lblNumElements.Text = "Elts in list one: " + lbOne.Items.Count;
            }
        }

        private void btnTransferTwo_Click(object sender, EventArgs e)
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
                lbOne.Items.Add(lbTwo.SelectedItem);
                lblNumElements.Text = "Elts in list one: " + lbOne.Items.Count;
            }
        }

        private int numberOfPoints = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Escribir el titulo en el text en las primeras comillas y que ahi se vaya agregarando la letra que muestra en el punto 
            int i = 0;
            string title = "Ejercicio 5";
            int maxPoints = title.Length;

            Text = " " + new string('.', numberOfPoints);
            numberOfPoints = (numberOfPoints + 1) % (maxPoints + 1);
            i++;
        }

        private void lbOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOne.SelectedIndex > -1)
            {
                lblIndex.Text = "Index of element: " + lbOne.SelectedIndex;
            }
            else
            {
                lblIndex.Text = "Index of element";
            }
        }
    }
}