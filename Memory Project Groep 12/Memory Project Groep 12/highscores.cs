using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Project_Groep_12
{
    public partial class Highscores : Form
    {
        public Highscores()
        {
            InitializeComponent();
        }

                
        private void Highscores_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            switch (hoofdmenu.Achtergrond)
            {
                case "frozen": this.BackgroundImage = Properties.Resources.frozen; break;
                case "auto": this.BackgroundImage = Properties.Resources.auto; break;
                case "starwars": this.BackgroundImage = Properties.Resources.starwars; break;
            }
            //NaamLijst.Text = spelers.naam1;

            string[] HighscoreN = new string[2];
            HighscoreN[0] = spelers.naam1;
            HighscoreN[1] = spelers.naam2;

            for (int i =0; i < HighscoreN.Length; i++)
            {
                NaamLijst.Text += HighscoreN[i] + "\n";
            }

           /* int[] HighscoreP = new int[10];
            for (int i = 0; i < HighscoreN.Length; i++)
            {
                HighscoreP[0] = 0; //placeholder
                HighscoreP[1] = 0; //placeholder

                foreach (int punten in HighscoreP)
                {
                    HighscoreP[punten] = 5;
                }
            }
            */
        }

        private void terug_Click(object sender, EventArgs e)
        {
            this.Hide();
            var highscores = new hoofdmenu();
            highscores.Closed += (s, args) => this.Close();
            highscores.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
