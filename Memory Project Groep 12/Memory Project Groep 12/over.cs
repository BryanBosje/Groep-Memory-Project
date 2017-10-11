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
            hoofdmenu.Play();
            this.Hide();
            hoofdmenu openen = new hoofdmenu();
            openen.ShowDialog();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            hoofdmenu.Play();
            System.Windows.Forms.Application.Exit();
        }
    }
}
