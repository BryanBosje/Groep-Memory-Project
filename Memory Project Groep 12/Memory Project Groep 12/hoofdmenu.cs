using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using WMPLib;
=======
>>>>>>> 06983b7a02f2ca4a9b65cddddcb7a7574a0ea3f6

namespace Memory_Project_Groep_12
{
    public partial class hoofdmenu : Form
    {
<<<<<<< HEAD
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public hoofdmenu()
        {
            InitializeComponent();
            player.URL = ("Background.MP3");
=======
        public hoofdmenu()
        {
            InitializeComponent();
>>>>>>> 06983b7a02f2ca4a9b65cddddcb7a7574a0ea3f6
        }

        private void play_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Play();
            this.Hide();
            game openen = new game();
            openen.ShowDialog();
        }

        private void quit_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Play();
            this.Close();
=======
            System.Windows.Forms.Application.Exit();
>>>>>>> 88383c0c238fe704559a05e64946daf1223c4718
=======
            this.Hide();
            game openen = new game();
            openen.ShowDialog();
         }

        private void quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
>>>>>>> 06983b7a02f2ca4a9b65cddddcb7a7574a0ea3f6
        }

        private void opties_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Play();
=======
>>>>>>> 06983b7a02f2ca4a9b65cddddcb7a7574a0ea3f6
            this.Hide();
            opties openen = new opties();
            openen.ShowDialog();
        }

        private void highscores_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Play();
=======
>>>>>>> 06983b7a02f2ca4a9b65cddddcb7a7574a0ea3f6
            this.Hide();
            Highscores openen = new Highscores();
            openen.ShowDialog();
        }

        private void over_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Play();
=======
>>>>>>> 06983b7a02f2ca4a9b65cddddcb7a7574a0ea3f6
            this.Hide();
            over openen = new over();
            openen.ShowDialog();
        }
<<<<<<< HEAD

        private void hoofdmenu_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void muteUnmute_CheckedChanged(object sender, EventArgs e)
        {
            Play();
            System.Windows.Forms.CheckBox muteUnmute = (System.Windows.Forms.CheckBox)sender;

            muteUnmute.Text = muteUnmute.Checked ? "Un-mute Audio" : muteUnmute.Text = "Mute Audio";

            player.settings.mute = muteUnmute.Checked;
        }

        static public void Play()
        {
            string soundfile = "Click.wav";
            var sound = new System.Media.SoundPlayer(soundfile);
            sound.Play();
        }
=======
>>>>>>> 06983b7a02f2ca4a9b65cddddcb7a7574a0ea3f6
    }
}
