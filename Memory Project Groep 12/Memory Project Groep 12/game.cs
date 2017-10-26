using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Memory_Project_Groep_12
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }

        PictureBox prev;
        byte flag = 0;
        int remain = 8;

        void Resetimage()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Image = Properties.Resources._0;
                }
            }
        }

        void ResetTags()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Tag = "0";
                }
            }
        }

        void SetTagRandom()
        {
            int[] arr = new int[16];
            int index = 0;
            Random rand = new Random();
            int r;
            while (index < 16)
            {
                r = rand.Next(1, 17);
                if (Array.IndexOf(arr, r) == -1)
                {
                    arr[index] = r;
                    index++;
                }
            }
            for (index = 0; index < 16; index++)
            {
                if (arr[index] > 8) arr[index] -= 8;
            }
            index = 0;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Tag = arr[index].ToString();
                    index++;
                }
            }
        }

        private void Terug_Click(object sender, EventArgs e)
        {
            this.Hide();
            var game = new hoofdmenu();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Opnieuw_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        void Compare(PictureBox previous, PictureBox current)
        {
            if (previous.Tag.ToString() == current.Tag.ToString())
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                previous.Visible = false;
                current.Visible = false;
            }
            else
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                previous.Image = Image.FromFile("0.png");
                current.Image = Image.FromFile("0.png");
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            Resetimage();
            ResetTags();
            SetTagRandom();
        }

        #region
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox current = (sender as PictureBox);
            (sender as PictureBox).Image = Image.FromFile((sender as PictureBox).Tag.ToString() + ".png");
            if(flag == 0)
            {
                prev = current;
                flag = 1;
            }
            else if (prev != current)
            {
                Compare(prev, current);
                flag = 0;
            }

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {

        }
        #endregion
        //Cards




        }
    }

