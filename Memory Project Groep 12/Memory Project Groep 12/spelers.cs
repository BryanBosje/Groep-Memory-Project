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
    public partial class spelers : Form
    {
        //Namen
        public static string naam1 = "";
        public static string naam2 = "";

        public spelers()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            naam1 = tekst_speler1.Text;
            naam2 = tekst_speler2.Text;
            this.Hide();
            var spelers = new game();
            spelers.Closed += (s, args) => this.Close();
            spelers.Show();
        }

        private void spelers_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;

            switch (hoofdmenu.Achtergrond)
            {
                case "frozen": this.BackgroundImage = Properties.Resources.frozen; break;
                case "auto": this.BackgroundImage = Properties.Resources.auto; break;
                case "starwars": this.BackgroundImage = Properties.Resources.starwars; break;
            }
        }
    }
}
