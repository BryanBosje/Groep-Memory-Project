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
        //Making soundplayer
        System.Media.SoundPlayer newmusic = new System.Media.SoundPlayer();

        //Getting volume
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        //Background tag
        public static string Achtergrond = "";

        public hoofdmenu()
        {
            PlayMusic(); //Play music on startup hoofdmenu
            InitializeComponent();
        }
        public void PlayMusic()
        {
            newmusic.Stream = Properties.Resources.Background; //Give soundplayer files to play from resources
            //newmusic.Play();
            bool playing = false; //Check if already playing, if not, start playing.
            if (playing == false)
            {
                newmusic.Play();
                playing = true;
            }
        }
        //Start the game and hide/close hoofdmenu
        private void play_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hoofdmenu = new spelers();
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }
        //Exit the application
        private void quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        //Open "Highscores" menu
        private void highscores_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hoofdmenu = new Highscores();
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }
        //Open "About" menu
        private void over_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hoofdmenu = new over();
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }
        //Hoofdmenu theme options
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
        //Mute / Unmute audio
        private void muteUnmute_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox muteUnmute = (System.Windows.Forms.CheckBox)sender;

            muteUnmute.Text = muteUnmute.Checked ? "Un-mute Audio" : muteUnmute.Text = "Mute Audio";

           if (muteUnmute.Checked) //Stop or play the music depending if the mute button is checked or not
            {
                newmusic.Stop();
            }
           else
            {
                newmusic.Play();
            }
           
        }
        //Star wars theme
        private void starwars_Click(object sender, EventArgs e)
        {
            Achtergrond = "starwars"; //tags background variable as theme name
            this.BackgroundImage = Properties.Resources.starwars; //loads the theme picture as background
        }
        //Standard theme
        private void Standaard_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
        }
        //Frozen theme
        private void frozen_Click(object sender, EventArgs e)
        {
            Achtergrond = "frozen";
            this.BackgroundImage = Properties.Resources.frozen; 
        }
        //Car theme
        private void auto_Click(object sender, EventArgs e)
        {
            Achtergrond = "auto";
            this.BackgroundImage = Properties.Resources.auto;
        }
        //Volume slider for sound, yet to be filled
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
          // newmusic
        }
    }
}
