using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Form2 : Form
    {

        public int tries = 3;
        string pin = "1234";
        public Form2()
        {
            InitializeComponent();
            lblTries.Text = tries + " Tries left";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtPin.Text != pin)
            {
                if (tries < 1)
                {
                    this.Close();
                }
                else
                {
                    tries--;
                    lblTries.Text = tries + " Tries left";
                    txtPin.Text = "";
                }
            }
        }
    }
}
