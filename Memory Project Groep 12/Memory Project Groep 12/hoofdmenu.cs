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
            game openen = new game();
            openen.ShowDialog();
         }

        private void quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void opties_Click(object sender, EventArgs e)
        {
            this.Hide();
            opties openen = new opties();
            openen.ShowDialog();
        }

        private void highscores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Highscores openen = new Highscores();
            openen.ShowDialog();
        }

        private void over_Click(object sender, EventArgs e)
        {
            this.Hide();
            over openen = new over();
            openen.ShowDialog();
        }
    }
}
