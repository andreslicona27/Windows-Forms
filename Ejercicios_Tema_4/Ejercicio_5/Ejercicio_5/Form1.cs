using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        ToolTip ttip = new ToolTip();
        public bool variableRepeated(ListBox listBox, string element)
        {
            bool repeated = false;
            foreach (var item in listBox.Items)
            {
                if (item.ToString().Equals(element))
                {
                    repeated = true;
                }
            }
            return repeated;
        }
        public Form1()
        {
            InitializeComponent();
            ttip.SetToolTip(this.btnAdd, "Add element at list one");
            ttip.SetToolTip(this.btnDelete, "Delete element at list one");
            ttip.SetToolTip(this.btnTransferOne, "Transfer elements from list two to list two");
            ttip.SetToolTip(this.btnTransferTwo, "Transfer elements from list one to list one");
            ttip.SetToolTip(this.lbOne, "List numer one");
            ttip.SetToolTip(this.lbTwo, "Elts in list two " + lbTwo.Items.Count.ToString());
            ttip.SetToolTip(this.tbElement, "Write the elment you want to add");
            ttip.SetToolTip(this.lblNumElements, "Amount of elements in list one");
            ttip.SetToolTip(this.lblIndex, "Index of selected elements in list one");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!variableRepeated(lbOne, tbElement.Text))
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

        private void btnTransferOne_Click(object sender, EventArgs e)
        {
            if (lbOne.Items.Count > 0 && lbOne.SelectedIndex > 0)
            {
                while (lbOne.SelectedIndices.Count > 0)
                {
                    for (int i = 0; i < lbOne.SelectedIndices.Count; i++)
                    //for (int i = lbOne.SelectedIndices.Count; i >= 0; i--)
                    {
                        if (!variableRepeated(lbTwo, lbOne.SelectedItems[i].ToString()))
                        {
                            //lbTwo.Items.Add(lbOne.SelectedItems[i]);
                            lbTwo.Items.Insert(0, lbOne.SelectedItems[i]);
                        }
                            lbOne.Items.Remove(lbOne.SelectedItems[i]);
                            lblNumElements.Text = "Elts in list one: " + lbOne.Items.Count;
                    }
                }

            }

        }

        private void btnTransferTwo_Click(object sender, EventArgs e)
        {
            if (lbTwo.Items.Count > 0 && lbTwo.SelectedIndex > 0)
            {
                if (!variableRepeated(lbOne, lbTwo.SelectedItem.ToString()))
                {
                    lbOne.Items.Add(lbTwo.SelectedItem);
                    lbTwo.Items.Remove(lbTwo.SelectedItem);
                    lblNumElements.Text = "Elts in list one: " + lbOne.Items.Count;
                }

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int cont = 9;
            string title = "Exercise 5";
            string titleText = title;
            string titleShowing; ;
            int maxPoints = title.Length;

            //Text = titleText.Substring(0, maxPoints);
            if (cont <= 0)
            {
                cont = titleText.Length - 1;
            }
            else
            {
                titleShowing = titleText[cont] + Text;
                if (titleShowing.Length >= cont)
                {
                    titleShowing = titleShowing.Substring(0, cont);
                    Text = titleShowing;
                }
                else
                {
                    Text = " ";
                    cont--;
                }
            }

        }

        private void lbOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOne.SelectedIndex > -1 && lbOne.SelectedIndices.Count < 2)
            {
                lblIndex.Text = "Index of element: " + lbOne.SelectedIndex;
            }
            else if (lbOne.SelectedIndex > -1 && lbOne.SelectedIndices.Count > 1)
            {
                lblIndex.Text = "Index of elements: ";
                for (int i = lbOne.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    lblIndex.Text += " " + lbOne.SelectedIndices[i];
                }
            }
            else
            {
                lblIndex.Text = "Index of element";
            }


        }
    }
}