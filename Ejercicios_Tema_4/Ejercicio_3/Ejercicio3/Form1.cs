namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sure you want to close the program?", "My App",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*| jpg files(*.jpg)|*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            Form2 f2 = new Form2();
            try
            {
                if (filePath.Length > 0)
                {
                    Image newImage = Image.FromFile(filePath);

                    f2.FormImage = newImage;
                    f2.FilePath = filePath;

                    if (!cbModal.Checked)
                    {
                        f2.Show();
                    }
                    else
                    {
                        DialogResult res;
                        res = f2.ShowDialog();
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("You have to choose an image", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("I can´t show that path", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void cbModal_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbModal.Checked)
            {
                cbModal.ForeColor = Color.Red;
            }
            else
            {
                cbModal.ForeColor = Color.Black;
            }
        }
    }
}