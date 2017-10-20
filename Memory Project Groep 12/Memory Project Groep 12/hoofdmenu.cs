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
using System.IO;
using System.Media;

namespace Memory_Project_Groep_12
{
    public partial class hoofdmenu : Form
    {
        
        public hoofdmenu()
        {
            PlayMusic();
            InitializeComponent();
            System.Media.SoundPlayer newmusic = new System.Media.SoundPlayer();
            newmusic.Stream = Properties.Resources.Background;
            newmusic.Play();
        }

        public void PlayMusic()
        {
            bool playing = false;
            if (playing == false)
            {
                //hoofdmenu.newmusic.Play();
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            Play();
            this.Hide();
            var hoofdmenu = new spelers();
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
            var hoofdmenu = new Highscores();
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }

        private void over_Click(object sender, EventArgs e)
        {
            Play();
            this.Hide();
            var hoofdmenu = new over();
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }

        private void hoofdmenu_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            switch (hoofdmenu.Achtergrond)
            {
                case "frozen": this.BackgroundImage = Properties.Resources.frozen; break;
                case "auto": this.BackgroundImage = Properties.Resources.auto; break;
                case "starwars": this.BackgroundImage = Properties.Resources.starwars; break;
            }
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

            // hoofdmenu.newmusic.settings.mute = muteUnmute.Checked;
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
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // player.settings.volume = trackBar1.Value;
        }
    }
}
