using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_of_Doom
{
    public partial class Scare : Form
    {
        public Scare()
        {
            InitializeComponent();

            //This is what turns this Full Screen
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            //This is what starts the Music
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.scare;
            player.Play();
        }

        //This makes the exit button, Close "This" aka the Scare Form.
        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
