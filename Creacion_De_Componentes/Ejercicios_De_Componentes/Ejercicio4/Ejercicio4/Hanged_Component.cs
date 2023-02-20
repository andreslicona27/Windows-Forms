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

        }


        [Category("The Property Change")]
        [Description("Happens when the propertie mistakes changes")]
        public event EventHandler MistakesChanged;

        [Category("The Property Change")]
        [Description("Occurs when the man is hanged and you lose")]
        public event EventHandler Hanged;
    }
}
