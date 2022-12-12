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

            Form2 pinForm = new Form2();
            //Showing the modal form for it to show before the principal form comes out 

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

                // FUNCTIONS 
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

            btnReset = new Button();
            // PROPERTIES
            btnReset.Text = "Reset";
            btnReset.BackColor = btnColor;
            btnReset.Location = new Point(11, 254);
            btnReset.Size = new Size(245, 39);

            // FUNCTIONS 
            this.btnReset.Click += new EventHandler(this.button1_Click);
            this.btnReset.MouseEnter += new EventHandler(this.btn_MouseEnter);
            this.btnReset.MouseLeave += new EventHandler(this.btn_MouseLeave);
            this.Controls.Add(btnReset);

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
                ((Button)sender).BackColor = Color.Gainsboro;

            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.Gainsboro)
            {
                ((Button)sender).BackColor = Color.Yellow;
            }
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.Gainsboro)
            {
                ((Button)sender).BackColor = btnColor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            foreach (Control con in this.Controls)
            {
                if (con.GetType() == typeof(Button))
                {
                    con.BackColor = btnColor;
                }
            }
            btnReset.BackColor = btnColor;
        }

        private void saveNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "txt|*.txt|All files|*.*";
                saveFileDialog1.Title = "Save Number";
                saveFileDialog1.ShowDialog();

                if (txtNumber.Text != "")
                {
                    using (StreamReader sr = new StreamReader("MyNumber.txt"))
                    {
                        Console.WriteLine(sr.ReadToEnd());
                    }

                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The file was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("The directory was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show("The file could not be opened.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}