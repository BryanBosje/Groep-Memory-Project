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
        //variables
        int score = 0; // scores
        Random location = new Random(); // selects a random value from list X and Y and assigns a new location to each card
        bool again = false;
        List<int> X = new List<int>(); // X values of the picture boxes
        List<int> Y = new List<int>(); // Y value of the picture boxes
        public game()
        {
            InitializeComponent();
        }


        private void game_Load(object sender, EventArgs e)
        {
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Image = Properties.Resources.Cover;
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void terug_Click(object sender, EventArgs e)
        {
            this.Hide();
            hoofdmenu openen = new hoofdmenu();
            openen.ShowDialog();
        }
    }
}
