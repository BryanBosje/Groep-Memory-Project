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
            this.Hide();
            var highscores = new hoofdmenu();
            highscores.Closed += (s, args) => this.Close();
            highscores.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
