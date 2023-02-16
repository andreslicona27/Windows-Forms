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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestComponent
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += new EventHandler(timer_function);

            for(int i = 0; i <= 20; i++)
            {
                cbFrecuency.Items.Add(i);
            }
        }

        private void player1_DesbordaTiempo(object sender, EventArgs e)
        {
            player1.Minutes += 1;
        }


        Image[] images;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DirectoryInfo directory;
            FileInfo[] files;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string directoryPath = fbd.SelectedPath;
                lblDirectorySelected.Text = "Directory selected";
                try
                {
                    if (directoryPath != string.Empty)
                    {
                        directory = new DirectoryInfo(directoryPath);
                        files = directory.GetFiles().ToArray();
                        images = new Image[files.Length];

                        for (int i = 0; i < images.Length; i++)
                        {
                            try
                            {
                                images[i] = Image.FromFile(files[i].FullName);
                            }
                            catch (IOException)
                            {
                                MessageBox.Show("An error has ocurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("We dont find the directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException)
                {
                    MessageBox.Show("An error ocurred in the selection of the directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        
        private void player1_PlayClick(object sender, EventArgs e)
        {
            if (player1.Paused)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
        }

        int showingImage = 0;
        private void timer_function(object sender, EventArgs e)
        {
            player1.Seconds += 1;
            if(showingImage < images.Length)
            {
                pbImages.Image = images[showingImage];
                showingImage++;
            }
        }

        private void cbFrecuency_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer.Interval = int.Parse(cbFrecuency.SelectedItem.ToString()) * 1000;
        }
    }
}
