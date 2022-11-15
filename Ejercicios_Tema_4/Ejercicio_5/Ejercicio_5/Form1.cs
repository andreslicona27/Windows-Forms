using System.Windows.Forms;

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

        }
    }
}