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
using System.Media;
using System.IO;
using System.Runtime.InteropServices;

namespace Memory_Project_Groep_12
{
    public partial class hoofdmenu : Form
    {
        System.Media.SoundPlayer newmusic = new System.Media.SoundPlayer();
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        public hoofdmenu()
        {
            PlayMusic();
            InitializeComponent();
        }
        public void PlayMusic()
        {
            //System.Media.SoundPlayer newmusic = new System.Media.SoundPlayer();
            newmusic.Stream = Properties.Resources.Background;
            //newmusic.Play();
            bool playing = false;
            if (playing == false)
            {
                newmusic.Play();
                playing = true;
            }
        }
        private void play_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hoofdmenu = new spelers();
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            //Play();
            System.Windows.Forms.Application.Exit();
        }

        private void highscores_Click(object sender, EventArgs e)
        {
            //Play();
            this.Hide();
            var hoofdmenu = new Highscores();
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }

        private void over_Click(object sender, EventArgs e)
        {
            //Play();
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
        //public void Play()
        //{
        //    System.Media.SoundPlayer ClickPlay = new System.Media.SoundPlayer();
        //    ClickPlay.Stream = Properties.Resources.Click;
        //    ClickPlay.Play();
        //}
        private void muteUnmute_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox muteUnmute = (System.Windows.Forms.CheckBox)sender;

            muteUnmute.Text = muteUnmute.Checked ? "Un-mute Audio" : muteUnmute.Text = "Mute Audio";

           if (muteUnmute.Checked)
            {
                newmusic.Stop();
            }
           else
            {
                newmusic.Play();
            }
           
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
          // newmusic
        }
    }
}
