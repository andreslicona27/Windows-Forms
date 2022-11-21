namespace Ejercicio_1_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender == button1)
            {
                Text = String.Format("Mouse Tester X:{0} Y:{1}",
                e.Location.X + button1.Location.X,
                e.Location.Y + button2.Location.Y);

            }
            else if (sender == button2)
            {
                Text = String.Format("Mouse Tester X:{0} Y:{1}",
                e.Location.X + button2.Location.X,
                e.Location.Y + button2.Location.Y);
            }
            else
            {
                Text = String.Format("Mouse Tester X:{0} Y:{1}", e.Location.X, e.Location.Y);
            }

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Text = "Mouse Tester";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button)
            {
                Text = String.Format("Mouse Tester X:{0} Y:{1}", e.Location.X + ((Button)sender).Location.X, e.Location.Y + ((Button)sender).Location.X);
            }
            else
            {
                Text = String.Format("Mouse Tester X:{0} Y:{1}", e.Location.X, e.Location.Y);
            }

        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.White;

            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.White;
            }
            else
            {
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
#if DEBUG
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "Mouse Tester";
            }
            else
            {
                this.Text = string.Format("Mouse Tester / condigo de letra: {0}", e.KeyValue.ToString());
            }
#endif

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
#if !DEBUG
            this.Text = string.Format("Mouse Tester / letra pulsada: {0}", e.KeyChar.ToString());

#endif
        }
    }
}