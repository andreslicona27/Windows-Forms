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
            Form2 f2 = new Form2();
            f2.Close();

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*| jpg files(*.jpg)|*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    // // // This is to read a file in case its a text file
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            if (MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK) == DialogResult.OK)
            {
                Form2 f2 = new Form2();
                try
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
                catch (ArgumentException)
                {
                    MessageBox.Show("You have to choose an image", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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