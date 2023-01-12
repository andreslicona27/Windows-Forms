using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_1
{
    public enum ePosicion
    {
        IZQUIERDA, DERECHA
    }
    public partial class LabelTextbox : UserControl
    {
        public LabelTextbox()
        {
            InitializeComponent();
        }

        private ePosicion posicion = ePosicion.IZQUIERDA;
        [Category("Clase DI")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    recolocar();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        private int separacion = 0;
        [Category("Clase DI")]
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    OnSeparacionChanged(EventArgs.Empty);
                    recolocar();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        // The private element of text it all ready exists, so you dont need to added
        // You just add the access to te property

        [Category("Clase DI")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }
        [Category("Clase DI")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt

        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }


        [Category("Clase DI")]
        [Description("Convertir el texto del textbox en uno de contraseña")]
        public char PswChr
        {
            set
            {
                txt.PasswordChar = value;
            }
            get
            {
                return txt.PasswordChar;
            }
        }


        private void recolocar()
        {
            switch (posicion)
            {
                case ePosicion.IZQUIERDA:
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(0, 0);
                    // Establecemos posición componente txt
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    //Establecemos ancho del Textbox
                    //(la label tiene ancho por autosize)
                    // El primero cambia el tamaño del txt y deja igual el tamaño del componenete, el segundo cambia el tamaño del componenete y deja igual el del txt
                    //txt.Width = this.Width - lbl.Width - Separacion;
                    this.Width = txt.Width + lbl.Width + Separacion;
                    //Establecemos altura del componente
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case ePosicion.DERECHA:
                    //Establecemos posición del componente txt
                    txt.Location = new Point(0, 0);
                    //Establecemos ancho del Textbox
                    // El primero cambia el tamaño del txt y deja igual el tamaño del componenete, el segundo cambia el tamaño del componenete y deja igual el del txt
                    //txt.Width = this.Width - lbl.Width - Separacion;
                    this.Width = txt.Width + lbl.Width + Separacion;
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    //Establecemos altura del componente (Puede sacarse del switch)
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }


        // Esta función has de enlazarla con el evento SizeChanged.
        // Sería necesario también tener en cuenta otros eventos como FontChanged
        // que aquí nos saltamos.
        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad tamaño cambia")]
        public event System.EventHandler SizeChanged;

        protected override void OnSizeChanged(EventArgs e)
        {
            if (SizeChanged != null)
            {
                recolocar();
            }
        }

        private void lbl_ChangedSize(object sender, EventArgs e)
        {
            this.OnSizeChanged(e);
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad separacion cambia")]
        public event System.EventHandler SeparacionChanged;

        protected virtual void OnSeparacionChanged(EventArgs e)
        {
            if (SeparacionChanged != null)
            {
                SeparacionChanged(this, e);
            }
        }


        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }


        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad texto cambia")]
        public event System.EventHandler TxtChanged;
        protected virtual void OnTxtChanged(EventArgs e)
        {
            if (TxtChanged != null)
            {
                TxtChanged(this, e);
            }
        }

        private void txt_TextChanged2(object sender, EventArgs e)
        {
            this.OnTxtChanged(EventArgs.Empty);
        }
    }
}
