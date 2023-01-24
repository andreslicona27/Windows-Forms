using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Ejercicio_3
{
    public partial class Player : UserControl
    {
        public Player()
        {
            InitializeComponent();
            lblTime.Text = "00:00";
        }

        // PROPERTIES
        private bool paused;
        public bool Paused
        {
            set { paused = value; }
            get { return paused; }
        }

        private int seconds;
        [Category("Appearance")]
        [Description("Initial value in the seconds part")]
        public int Seconds
        {
            set
            {
                seconds = value;
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else if (seconds > 59)
                {
                    seconds = value % 60;
                    DesbordaTiempo(this, EventArgs.Empty);
                }
                else if (minutes > 59)
                {
                    value = 0;
                }
            }
            get
            {
                return seconds;
            }
        }

        private int minutes;
        [Category("Appearance")]
        [Description("Initial value in the minutes part")]
        public int Minutes
        {
            set
            {
                if (minutes < 0)
                {
                    throw new ArgumentException();
                }
                else if (minutes <= 60)
                {
                    minutes = value - 60;
                }
                else
                {
                    minutes = value;
                }
            }
            get
            {
                return minutes;
            }
        }

        // FUNCTIONS
        [Category("Action")]
        [Description("Initial value in the minutes part")]
        public event System.EventHandler PlayClick;

        private void OnPlayClick(object sender, EventArgs e)
        {
            if (paused)
            {
                lblTime.Text = "||";
                paused = true;
            }
            else
            {
                lblTime.Text = ">";
                paused = false;
            }
            PlayClick(this, EventArgs.Empty);
        }


        [Category("Appearance")]
        [Description("Initial value in the minutes part")]
        public event System.EventHandler DesbordaTiempo;

    }
}
