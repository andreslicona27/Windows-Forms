using Ejercicio_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(eMarca.Nada);
            comboBox1.Items.Add(eMarca.Circulo);
            comboBox1.Items.Add(eMarca.Cruz);
            comboBox1.Items.Add(eMarca.ImagenMarca);
            comboBox1.SelectedIndex = 0;
        }

        private void etiquetaAviso1_ClickEnMarca(object sender, EventArgs e)
        {
            MessageBox.Show("You click the image", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ea.Marca = (eMarca)comboBox1.SelectedItem;
        }
    }
}
