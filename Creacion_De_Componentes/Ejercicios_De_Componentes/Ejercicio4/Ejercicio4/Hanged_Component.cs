using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Hanged_Component: UserControl
    {
        private int DEFAULT_WIDTH = 185;
        private int DEFAULT_HEIGHT = 205;

        private float DEFAULT_UNIT_SCALE_X = 1f;
        private float DEFAULT_UNIT_SCALE_Y = 1f;

        private float UNIT_SCALE_X;
        private float UNIT_SCALE_Y;
        public Hanged_Component()
        {
            InitializeComponent();
        }

        [Category("The Property Change")]
        [Description("Fired when the Mistakes property change")]
        private int mistakes;

        public int Mistakes
        {
            set
            {
                if (value >= 0)
                {
                    mistakes = value;
                    MistakesChanged?.Invoke(this, EventArgs.Empty);
                    this.Refresh();
                }

                if (value >= 7)
                {
                    Hanged?.Invoke(this, EventArgs.Empty);
                }
            }
            get { return mistakes; }
        }

        protected void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            float thickness = scaleX(2);
            float x = scaleX(0);
            float y = scaleY(200);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Black, thickness);

            switch (Mistakes)
            {
                case 0:
                    break;
                case 1:
                    goto case 0;
                case 2:
                    goto case 1;
                case 3:
                    goto case 2;
                case 4:
                    goto case 3;
                case 5:
                    goto case 4;
                case 6:
                    goto case 5;
                case 7:
                    goto case 6;
            }

        }

        private float scaleX(float value) => value * UNIT_SCALE_X;

        private float scaleY(float value) => value * UNIT_SCALE_Y;

        [Category("The Property Change")]
        [Description("Happens when the propertie mistakes changes")]
        public event EventHandler MistakesChanged;

        [Category("The Property Change")]
        [Description("Occurs when the man is hanged and you lose")]
        public event EventHandler Hanged;
    }
}
