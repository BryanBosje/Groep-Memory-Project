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

        }

        private void terug_Click(object sender, EventArgs e)
        {
            hoofdmenu.Play();
            this.Hide();
            hoofdmenu openen = new hoofdmenu();
            openen.ShowDialog();
        }

        private void quit_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            hoofdmenu.Play();
            this.Close();
=======
            System.Windows.Forms.Application.Exit();
>>>>>>> 88383c0c238fe704559a05e64946daf1223c4718
        }

    }
}
