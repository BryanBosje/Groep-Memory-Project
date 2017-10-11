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


        private void game_Load(object sender, EventArgs e)
        {
            hoofdmenu.Play();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            hoofdmenu.Play();
            this.Close();
        }

        private void terug_Click(object sender, EventArgs e)
        {
            hoofdmenu.Play();
            this.Hide();
            hoofdmenu openen = new hoofdmenu();
            openen.ShowDialog();
        }
    }
}
