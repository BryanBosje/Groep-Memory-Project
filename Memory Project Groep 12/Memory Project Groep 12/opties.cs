﻿using System;
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
<<<<<<< HEAD
            hoofdmenu.Play();
=======
>>>>>>> 06983b7a02f2ca4a9b65cddddcb7a7574a0ea3f6
            this.Hide();
            hoofdmenu openen = new hoofdmenu();
            openen.ShowDialog();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
<<<<<<< HEAD

        private void opties_Load(object sender, EventArgs e)
        {
            hoofdmenu.Play();
        }
=======
>>>>>>> 06983b7a02f2ca4a9b65cddddcb7a7574a0ea3f6
    }
}
