﻿using System;
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
            if (lbltxt1.Posicion == Ejercicio_1.ePosicion.IZQUIERDA)
            {
                lbltxt1.Posicion = Ejercicio_1.ePosicion.DERECHA;
            } else
            {
                lbltxt1.Posicion = Ejercicio_1.ePosicion.IZQUIERDA;
            }

            Text = lbltxt1.Posicion.ToString();
<<<<<<< HEAD

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Prueba de escritura de texto", this.Font, Brushes.BlueViolet, 10, 10);
=======
>>>>>>> refs/remotes/origin/main
        }
    }
}
