using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void player1_DesbordaTiempo(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog images = new OpenFileDialog();
            images.Filter = "Directorios|*.this.directory";

            try {
                if (images.ShowDialog() == DialogResult.OK)
                {
                    string dir = images.FileName;
                    // hacer algo con el directorio seleccionado
                }
            }
            catch
            {

            }


        }
    }
}
