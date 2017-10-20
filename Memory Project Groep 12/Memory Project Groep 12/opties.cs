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
    public partial class opties : Form
    {
        public opties()
        {
            InitializeComponent();
        }

        private void terug_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opties = new hoofdmenu();
            opties.Closed += (s, args) => this.Close();
            opties.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
