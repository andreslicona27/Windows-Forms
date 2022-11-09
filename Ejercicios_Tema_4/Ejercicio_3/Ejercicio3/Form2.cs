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
        string filePath;

        public Image FormImage
        {
            set
            {
                formImage = value;
            }
        }

        public string FilePath
        {
            set
            {
                filePath = value;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(filePath);
            var name = fi.Name;

            pbImage.Image = formImage;
            Text = name;
            this.Height = pbImage.Height;
            this.Width = pbImage.Width;


        }


    }
}
