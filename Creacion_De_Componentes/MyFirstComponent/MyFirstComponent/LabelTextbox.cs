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

namespace MyFirstComponent
{
    // Indicates where is the label from the textbox perspective 
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
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA delTextbox")]
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
                    // In case the position is not defined 
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        void recolocar() { }

        private int separacion = 0;
        // If you put the name of a category that does not exists it would create a new category with that name 
        [Category("Clase DI")]
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
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



        // Create a variable for que user to change the text of the componente but not to cahnge anything from the structire of the component
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
        [Category("CLase DI")]
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



    }
}
