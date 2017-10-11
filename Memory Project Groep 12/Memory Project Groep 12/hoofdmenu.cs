using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Memory_Project_Groep_12
{
    public partial class hoofdmenu : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public hoofdmenu()
        {
            InitializeComponent();
            player.URL = ("Background.MP3");
            player.controls.play();
        }

        private void play_Click(object sender, EventArgs e)
        {
            Play();
            this.Hide();
            game openen = new game();
            openen.ShowDialog();
         }

        private void quit_Click(object sender, EventArgs e)
        {
            Play();
            System.Windows.Forms.Application.Exit();
        }

        private void opties_Click(object sender, EventArgs e)
        {
            Play();
            this.Hide();
            opties openen = new opties();
            openen.ShowDialog();
        }

        private void highscores_Click(object sender, EventArgs e)
        {
            Play();
            this.Hide();
            Highscores openen = new Highscores();
            openen.ShowDialog();
        }

        private void over_Click(object sender, EventArgs e)
        {
            Play();
            this.Hide();
            over openen = new over();
            openen.ShowDialog();
        }
        static public void Play()
        {
            string soundfile = "Click.wav";
            var sound = new System.Media.SoundPlayer(soundfile);
            sound.Play();
        }
        private void muteUnmute_CheckedChanged(object sender, EventArgs e)
        {
                System.Windows.Forms.CheckBox muteUnmute = (System.Windows.Forms.CheckBox)sender;

                muteUnmute.Text = muteUnmute.Checked ? "Un-mute Audio" : muteUnmute.Text = "Mute Audio";

                player.settings.mute = muteUnmute.Checked;
        }
    }
}
