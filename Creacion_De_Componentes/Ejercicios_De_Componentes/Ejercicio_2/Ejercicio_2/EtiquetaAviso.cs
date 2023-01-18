using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;

namespace Ejercicio_2
{
    public enum eMarca
    {
        Nada,
        Cruz,
        Circulo,
        ImagenMarca
    }

    public partial class EtiquetaAviso : Control
    {
        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
                             // Altura de fuente, usada como referencia en varias partes
            int h = this.Font.Height;
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
            // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            if (Gradient)
            {
                LinearGradientBrush l = new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(this.Width, 0),
                    ginitial,
                    gfinal);

                g.FillRectangle(l, new Rectangle(0, 0, this.Width, this.Height));
                l.Dispose();

            }
            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case eMarca.ImagenMarca:
                    if (imagenMarca != null)
                    {
                        g.DrawImage(ImageMarca, new Rectangle(0, 0, this.FontHeight, this.FontHeight));
                    }
                    break;
            }

            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            if (Marca == eMarca.ImagenMarca && ImageMarca != null)
            {
                g.DrawString(this.Text, this.Font, b, offsetX + grosor + this.FontHeight, offsetY);
                Size tam = g.MeasureString(this.Text, this.Font).ToSize();
                this.Size = new Size(tam.Width + offsetX + grosor + this.FontHeight, tam.Height + offsetY * 2);
            }
            else
            {
                g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
                Size tam = g.MeasureString(this.Text, this.Font).ToSize();
                this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            }
            b.Dispose();




        }

        private eMarca marca = eMarca.Nada;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }
        }

        private bool gradient = false;
        [Category("Appearance")]
        [Description("Indicates if the componente has a linear gradient")]
        public bool Gradient
        {
            set
            {
                gradient = value;
                this.Refresh();
            }
            get
            {
                return gradient;
            }
        }

        private Color ginitial;
        [Category("Appearance")]
        [Description("Indicate the initial color of the linear gradient")]
        public Color GInitial
        {
            set
            {
                ginitial = value;
                this.Refresh();
            }
            get
            {
                return ginitial;
            }
        }

        private Color gfinal;
        [Category("Appearance")]
        [Description("Indicate the final color of the linear gradient")]
        public Color GFinal
        {
            set
            {
                gfinal = value;
                this.Refresh();
            }
            get
            {
                return gfinal;
            }
        }

        private Image imagenMarca;
        [Category("Appearance")]
        [Description("Image that would show in the mark of the label")]
        public Image ImageMarca
        {
            set
            {
                imagenMarca = value;
                this.Refresh();
            }
            get
            {
                return imagenMarca;
            }
        }

        [Category("Appearance")]
        [Description("It launches when the user makes a click in the mark")]
        public event System.EventHandler ClickEnMarca;

        protected virtual void OnClickEnMarca(EventArgs e)
        {
            if (ClickEnMarca != null)
            {
                ClickEnMarca(this, e);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.X <= this.FontHeight)
            {
                this.OnClickEnMarca(EventArgs.Empty);
            }
        }
    }
}
