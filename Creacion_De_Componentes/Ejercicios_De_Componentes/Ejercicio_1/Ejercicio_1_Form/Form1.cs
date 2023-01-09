using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            if (lbltxt1.Posicion.Equals("IZQUIERDA"))
            {
                lbltxt1.Posicion = Ejercicio_1.ePosicion.DERECHA;
            } else
            {
                lbltxt1.Posicion = Ejercicio_1.ePosicion.IZQUIERDA;
            }

        }
    }
}
