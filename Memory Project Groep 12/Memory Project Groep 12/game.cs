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
    }
}
