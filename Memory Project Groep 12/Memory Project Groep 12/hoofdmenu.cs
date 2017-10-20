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
            player.URL = ("Sound/Background.MP3");
            player.controls.play();
        }

        private void play_Click(object sender, EventArgs e)
        {
            Play();
            this.Hide();
<<<<<<< HEAD
            var hoofdmenu = new spelers();
=======
            var hoofdmenu = new game();
>>>>>>> bryan
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Play();
            System.Windows.Forms.Application.Exit();
        }

        private void highscores_Click(object sender, EventArgs e)
        {
            Play();
            this.Hide();
<<<<<<< HEAD
            var hoofdmenu = new Highscores();
=======
            var hoofdmenu = new opties();
>>>>>>> bryan
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }

        private void over_Click(object sender, EventArgs e)
        {
            Play();
            this.Hide();
<<<<<<< HEAD
            var hoofdmenu = new over();
=======
            var hoofdmenu = new Highscores();
>>>>>>> bryan
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }

        private void hoofdmenu_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            BackgroundImageLayout = ImageLayout.Stretch;
            switch (hoofdmenu.Achtergrond)
            {
                case "frozen": this.BackgroundImage = Properties.Resources.frozen; break;
                case "auto": this.BackgroundImage = Properties.Resources.auto; break;
                case "starwars": this.BackgroundImage = Properties.Resources.starwars; break;
            }
=======
            Play();
            this.Hide();
            var hoofdmenu = new over();
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }

        private void hoofdmenu_Load(object sender, EventArgs e)
        {

>>>>>>> bryan
        }
        static public void Play()
        {
            string soundfile = "Sound/Click.wav";
            var sound = new System.Media.SoundPlayer(soundfile);
            sound.Play();
        }
        private void muteUnmute_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox muteUnmute = (System.Windows.Forms.CheckBox)sender;

            muteUnmute.Text = muteUnmute.Checked ? "Un-mute Audio" : muteUnmute.Text = "Mute Audio";

            player.settings.mute = muteUnmute.Checked;
<<<<<<< HEAD
        }

        public static string Achtergrond = "";

        private void starwars_Click(object sender, EventArgs e)
        {
            Achtergrond = "starwars";
            this.BackgroundImage = Properties.Resources.starwars;
        }

        private void Standaard_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
        }

        private void frozen_Click(object sender, EventArgs e)
        {
            Achtergrond = "frozen";
            this.BackgroundImage = Properties.Resources.frozen;
        }

        private void auto_Click(object sender, EventArgs e)
        {
            Achtergrond = "auto";
            this.BackgroundImage = Properties.Resources.auto;
=======
>>>>>>> bryan
        }
    }
}
