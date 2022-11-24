using System.Drawing.Printing;
using System.Resources;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {

        public Color btnColor = Color.DimGray;
        public Form1()
        {
            InitializeComponent();
            btnReset.BackColor = btnColor;

            Form2 pinForm = new Form2();
            // Showing the modal form for it to show before the principal form comes out 
            //pinForm.ShowDialog();
            //if (pinForm.ShowDialog() == DialogResult.Cancel || pinForm.tries == 0)
            //{
            //    pinForm.Close();
            //    this.Close();
            //}
        }

        private Button btn;

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 70;
            btnReset.Click += new System.EventHandler(this.btn_Click);
            btnReset.MouseEnter += new EventHandler(this.btn_MouseEnter);
            btnReset.MouseLeave += new EventHandler(this.btn_MouseLeave);

            // BUTTONS CREATON AND POSITIONING
            for (int i = 0; i < 12; i++)
            {
                // PROPERTIES
                btn = new Button();
                if (i == 9)
                {
                    btn.Text = "*";
                }
                else if (i == 10)
                {
                    btn.Text = "0";
                }
                else if (i == 11)
                {
                    btn.Text = "#";
                }
                else
                {
                    btn.Text = (i + 1).ToString();
                }
                btn.BackColor = btnColor;
                btn.Location = new Point(x, y);
                btn.Size = new Size(80, 40);

                // FUNCITONS 
                this.btn.Click += new EventHandler(this.btn_Click);
                this.btn.MouseEnter += new EventHandler(this.btn_MouseEnter);
                this.btn.MouseLeave += new EventHandler(this.btn_MouseLeave);
                this.Controls.Add(btn);

                // POSITIONING THE BUTTONS IN COLUMNS
                if ((i + 1) % 3 == 0)
                {
                    x = 10;
                    y += 40 + 5;
                }
                else
                {
                    x += 80 + 5;
                }
            }
        }

        private void aboutOfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App created by Andres Licona.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                txtNumber.Text += ((Button)sender).Text;
                ((Button)sender).BackColor = Color.BlueViolet;

            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.BlueViolet)
            {
                ((Button)sender).BackColor = Color.Aqua;
            }
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.BlueViolet)
            {
                ((Button)sender).BackColor = btnColor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNumber.Text = " ";
            foreach (Control con in this.Controls)
            {
                if (con.GetType() == typeof(Button))
                {
                    con.BackColor = btnColor;
                }
            }
        }

    }
}