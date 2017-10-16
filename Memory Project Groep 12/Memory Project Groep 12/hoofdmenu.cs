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
    public partial class hoofdmenu : Form
    {
        public hoofdmenu()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, EventArgs e)
        {
            this.Hide();
            var game = new game();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void opties_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opties = new opties();
            opties.Closed += (s, args) => this.Close();
            opties.Show();
        }

        private void highscores_Click(object sender, EventArgs e)
        {
            this.Hide();
            var highscores = new Highscores();
            highscores.Closed += (s, args) => this.Close();
            highscores.Show();
        }

        private void over_Click(object sender, EventArgs e)
        {
            this.Hide();
            var over = new over();
            over.Closed += (s, args) => this.Close();
            over.Show();
        }

        private void hoofdmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
