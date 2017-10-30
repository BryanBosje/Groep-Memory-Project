using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Highscores
{
    public partial class Highscore : Form
    {
        public Highscore()
        {
            InitializeComponent();
        }

        private void SaveNaam_Click(object sender, EventArgs e)
        {
            if (NaamInput.Text != "")
            {
                NaamList.Items.Add(NaamInput.Text);
                NaamInput.Focus();
                NaamInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NaamInput.Focus();
            }
        }

        private void SaveScore_Click(object sender, EventArgs e)
        {
            if (ScoreInput.Text != "")
            {
                ScoreList.Items.Add(ScoreInput.Text);
                ScoreInput.Focus();
                ScoreInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter your score.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ScoreInput.Focus();
            }
        }
    }
}
