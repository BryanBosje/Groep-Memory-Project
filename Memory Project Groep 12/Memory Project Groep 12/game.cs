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
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }        

        private void terug_Click(object sender, EventArgs e)
        {
            this.Hide();
            var game = new hoofdmenu();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void opnieuw_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void game_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            switch (hoofdmenu.Achtergrond)
            {
                case "frozen": this.BackgroundImage = Properties.Resources.frozen; break;
                case "auto": this.BackgroundImage = Properties.Resources.auto; break;
                case "starwars": this.BackgroundImage = Properties.Resources.starwars; break;
            }
        }

        private void SaveNaam_Click(object sender, EventArgs e)
        {
            
            if (NaamInput.Text != "")
            {
                NaamList.Items.Add(NaamInput.Text);
                NaamInput.Focus();
                NaamInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NaamInput.Focus();
            }
        }

        private void Highscore_Click(object sender, EventArgs e)
        {
            this.Hide();
            var highscores = new Highscores();
            highscores.Closed += (s, args) => this.Close();
            highscores.Show();
        }
    }
}
