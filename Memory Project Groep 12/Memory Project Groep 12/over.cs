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
    public partial class over : Form
    {
        public over()
        {
            InitializeComponent();
        }

        private void over_Load(object sender, EventArgs e)
        {

        }

        private void terug_Click(object sender, EventArgs e)
        {
            this.Hide();
            var over = new hoofdmenu();
            over.Closed += (s, args) => this.Close();
            over.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
