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
    public partial class Form1 : Form
    {
        //Page 9 Adding Sound Player
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        //Here we establish the game is reset when endGame is activated, going out of bounds.
        private void endGame(object sender, EventArgs e)
        {
            reset();
        }

        //Here we establish that once the Start button is enabled, the game will start.
        private void start(object sender, EventArgs e)
        {
            button1.Enabled = false;
            StartGame();
        }

        //Logic for the Game once it Starts
        private void StartGame()
        {
            //Controls
            foreach (Control x in this.Controls)
            {
                //Change the Picture Boxes to blue once they are enabled
                if (x is PictureBox)
                {
                    x.Enabled = true;
                    x.BackColor = System.Drawing.Color.SkyBlue;
                }

                //Background Music begins once the Game Starts
                player.Stream = Properties.Resources.bg_music;
                player.PlayLooping();
            }
        }

        //Reset logic for the Maze. Resets colors back and Sets up starting point. 
        private void reset()
        {
            button1.Enabled = true;
            player.Stop();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Enabled = false;
                    x.BackColor = System.Drawing.Color.Black;
                }
            }
        }

        //Logic for what occurs when the ScarePlayer event is activated. Full Screen! 
        private void ScarePlayer(object sender, EventArgs e)
        {
            Scare fullscreen = new Scare();
            fullscreen.Show();
        }
    }
}
