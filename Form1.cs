using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // create global variables of String Type Array to save the titles or names
        String[] paths, files;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Write a code to play music
            WindowsMediaPlayer.URL = paths[listBoxSong.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // code select song
            OpenFileDialog ofd = new OpenFileDialog();
            // code select multiple files
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; // save the names  of the track in file array
                paths = ofd.FileNames; // save the path of the track in path array
                // display to music
                for (int i=0; i<files.Length;i++)
                {
                    listBoxSong.Items.Add(files[i]); //display songs in listbox
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // code to close
            this.Close();
        }
    }
}
