using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form2 : Form
    {
        Image formImage;

        public Image FormImage
        {
            set
            {
                formImage = value;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            pbImage.Image = formImage;
            this.Height = pbImage.Height;
            this.Width = pbImage.Width;
            Text = Path.GetFileName(formImage.ToString());

        }


    }
}
