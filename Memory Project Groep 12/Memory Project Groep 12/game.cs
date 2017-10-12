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
        //variables
        int score = 0; // scores
        Random location = new Random(); // selects a random value from list X and Y and assigns a new location to each card
        bool again = false;
        List<int> X = new List<int>(); // X values of the picture boxes
        List<int> Y = new List<int>(); // Y value of the picture boxes
        PictureBox PendingImage1; // Store first flipped card in this variable
        PictureBox PendingImage2; // Store Second flipped card into this variable

        public game()
        {
            InitializeComponent();
        }


        private void game_Load(object sender, EventArgs e)
        {
            foreach(PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;
            }
            timer1.Start();
            timer2.Start();
            pictureBox1.Image = Properties.Resources.Aardbeien;
            pictureBoxDup1.Image = Properties.Resources.Aardbeien;
            pictureBox2.Image = Properties.Resources.appeltjes;
            pictureBoxDup2.Image = Properties.Resources.appeltjes;
            pictureBox3.Image = Properties.Resources.banaantje;
            pictureBoxDup3.Image = Properties.Resources.banaantje;
            pictureBox4.Image = Properties.Resources.Druifjes;
            pictureBoxDup4.Image = Properties.Resources.Druifjes;
            pictureBox5.Image = Properties.Resources.kersies;
            pictureBoxDup5.Image = Properties.Resources.kersies;
            pictureBox6.Image = Properties.Resources.kiwie;
            pictureBoxDup6.Image = Properties.Resources.kiwie;
            pictureBox7.Image = Properties.Resources.mandarijntje;
            pictureBoxDup7.Image = Properties.Resources.mandarijntje;
            pictureBox8.Image = Properties.Resources.peertje;
            pictureBoxDup8.Image = Properties.Resources.peertje;           

        }

        private void quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void terug_Click(object sender, EventArgs e)
        {
            this.Hide();
            hoofdmenu openen = new hoofdmenu();
            openen.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.Cover;
            }
            timer1.Stop();
        }

        private void CountDown_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt16(CountDown.Text);
            timer = timer-1;
            CountDown.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
            }
        }

        //Card Values
        #region Cards
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Aardbeien;
            if (PendingImage1 == null)
            {
                PendingImage1 = pictureBox1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pictureBox1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {

                }
                else
                {
                    timer3.Start();
                }
                
            }
        }

        private void pictureBoxDup1_Click(object sender, EventArgs e)
        {
            pictureBoxDup1.Image = Properties.Resources.Aardbeien;
            pictureBox1.Image = Properties.Resources.Aardbeien;
            if (PendingImage1 == null)
            {
                PendingImage1 = pictureBoxDup1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pictureBoxDup1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {

                }
                else
                {
                    timer3.Start();
                }
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.appeltjes;
            pictureBox1.Image = Properties.Resources.Aardbeien;
            if (PendingImage1 == null)
            {
                PendingImage1 = pictureBox2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pictureBox2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {

                }
                else
                {
                    timer3.Start();
                }
                
            }
        }

        private void pictureBoxDup2_Click(object sender, EventArgs e)
        {
            pictureBoxDup2.Image = Properties.Resources.appeltjes;
            pictureBox1.Image = Properties.Resources.Aardbeien;
            if (PendingImage1 == null)
            {
                PendingImage1 = pictureBoxDup2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pictureBoxDup2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {

                }
                else
                {
                    timer3.Start();
                }
                
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.banaantje;
        }

        private void pictureBoxDup3_Click(object sender, EventArgs e)
        {
            pictureBoxDup3.Image = Properties.Resources.banaantje;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.Druifjes;
        }

        private void pictureBoxDup4_Click(object sender, EventArgs e)
        {
            pictureBoxDup4.Image = Properties.Resources.Druifjes;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.kersies;
        }

        private void pictureBoxDup5_Click(object sender, EventArgs e)
        {
            pictureBoxDup5.Image = Properties.Resources.kersies;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.kiwie;
        }

        private void pictureBoxDup6_Click(object sender, EventArgs e)
        {
            pictureBoxDup6.Image = Properties.Resources.kiwie;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.mandarijntje;
        }

        private void pictureBoxDup7_Click(object sender, EventArgs e)
        {
            pictureBoxDup7.Image = Properties.Resources.mandarijntje;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.peertje;
        }

        private void pictureBoxDup8_Click(object sender, EventArgs e)
        {
            pictureBoxDup8.Image = Properties.Resources.peertje;
        }
        #endregion

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PendingImage1.Image = Properties.Resources.Cover;
            PendingImage2.Image = Properties.Resources.Cover;
            PendingImage1 = null;
            PendingImage2 = null;
        }
    }
}
