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
        int timer, playerScore1, playerScore2, pairsLeft = 8;
        bool playerTurn = false; //false = player 1 turn, true = player 2 turn

        
        PictureBox prev;
        byte flag = 0;

        public game()
        {
            InitializeComponent();
            PlayerTurnLabel.Text = spelers.naam1 + " is aan de beurt.";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer = Convert.ToInt32(TimerCounter.Text);
            timer -= 1;
            TimerCounter.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time's Up!");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }
        //int remain = 8;

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

        private void opnieuw_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var game = new hoofdmenu();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void sluiten_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        void Compare(PictureBox previous, PictureBox current)
        {
            if (previous.Tag.ToString() == current.Tag.ToString())
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                previous.Visible = false;
                current.Visible = false;
                //ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                pairsLeft--;
                Points();

                if(pairsLeft <= 0)
                {
                    if (playerScore1 > playerScore2)
                        MessageBox.Show(spelers.naam1 + " Wins ya faggot");
                    else if (playerScore2 > playerScore1)
                        MessageBox.Show(spelers.naam2 + " Has no life");
                    else
                        MessageBox.Show("It's a tie you plebs!");

                    Highscore();
                }
            }
            else
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                previous.Image = Image.FromFile("0.png");
                current.Image = Image.FromFile("0.png");
                //Next Player
                if (playerTurn == true)
                {
                    playerTurn = false;
                    PlayerTurnLabel.Text = spelers.naam1 + " is aan de beurt.";
                }
                else
                {
                    playerTurn = true;
                    PlayerTurnLabel.Text = spelers.naam2 + " is aan de beurt.";
                }
            }
        }
        public void Points()
        {
            if (playerTurn == false)
            {
                //ScoreCounter1.Text = Convert.ToString(Convert.ToInt32(ScoreCounter1.Text) + 10);
                playerScore1 = Convert.ToInt32(ScoreCounter1.Text) + 10;
                ScoreCounter1.Text = Convert.ToString(playerScore1);
            }
            else
            {
                //ScoreCounter2.Text = Convert.ToString(Convert.ToInt32(ScoreCounter2.Text) + 10);
                playerScore2 = Convert.ToInt32(ScoreCounter2.Text) + 10;
                ScoreCounter2.Text = Convert.ToString(playerScore2);
            }
        }
        private void Game_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            switch (hoofdmenu.Achtergrond)
            {
                case "frozen": this.BackgroundImage = Properties.Resources.frozen; break;
                case "auto": this.BackgroundImage = Properties.Resources.auto; break;
                case "starwars": this.BackgroundImage = Properties.Resources.starwars; break;
            }
            Naam1.Text = /*"Speler 1 = " + */spelers.naam1;
            Naam2.Text = /*"Speler 2 = " + */spelers.naam2;
            Resetimage();
            ResetTags();
            SetTagRandom();
        }

        public void HighscoreB_Click_1(object sender, EventArgs e)
        {
            Highscore();
        }
        
        public void Highscore()
        {
            this.Hide();
            var highscores = new Highscores();
            highscores.Closed += (s, args) => this.Close();
            highscores.Show();
        }
        
        #region
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox current = (sender as PictureBox);
            (sender as PictureBox).Image = Image.FromFile((sender as PictureBox).Tag.ToString() + ".png");
            if (flag == 0)
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
        private void PictureBox16_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
        #endregion
        //Cards
    }
}
