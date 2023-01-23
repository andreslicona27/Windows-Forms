using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TestComponent
{
    public partial class Form1 : Form
    {
        Image[] images;
        int contImge = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void player1_DesbordaTiempo(object sender, EventArgs e)
        {

        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory;
            FileInfo[] files;
            string directoryPath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "png files (*.png)|*.png|jpg files(*.jpg)|*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    directoryPath = openFileDialog.FileName;
                }
                directory = new DirectoryInfo(directoryPath);
                files = directory.GetFiles().ToArray();

            }

            try
            {
                images = new Image[files.Length];
                if (directoryPath != string.Empty)
                {
                    for (int i = 0; i < directoryPath.Length; i++)
                    {
                        images[i] = Image.FromFile(files[i].FullName);
                    }
                }

            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("We dont find the directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("An error ocurred in the selection of the directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
