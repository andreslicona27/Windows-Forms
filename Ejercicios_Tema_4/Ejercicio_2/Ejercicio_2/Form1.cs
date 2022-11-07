using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Ejericio_2 : Form
    {

        public Ejericio_2()
        {
            InitializeComponent();
            btnColor.BackColor = Color.White;
            btnImagen.BackColor = Color.White;
            btnSalir.BackColor = Color.White;


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Application.Exit();
            }
        }


        private void btnColor_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtbRojo.Text);
                int num2 = int.Parse(txtbAzul.Text);
                int num3 = int.Parse(txtbVerde.Text);
                if (num1 < 0 || num1 > 255 || num2 < 0 || num2 > 255 || num3 < 0 || num3 > 255)
                {
                    MessageBox.Show("Debes agregar números entre 0 - 255", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.BackColor = Color.FromArgb(num1, num2, num3);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debes ingresar numeros en todos los campos", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                pb.Image = Image.FromFile(txtbRuta.Text);

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Agrega un path valido", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se ha encontrado esa imagen", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.LightSalmon;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
        }

        private void txtbRojo_CursorChanged(object sender, EventArgs e)
        {
            if (txtbRojo.Focused || txtbVerde.Focused || txtbAzul.Focused)
            {
                AcceptButton = btnColor;
            }
            else if (txtbRuta.Focused)
            {
                AcceptButton = btnImagen;
            }
        }

        
    }
}