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
        //game runtime related variables
        public static int timer, playerScore1, playerScore2, pairsLeft = 8;
        bool playerTurn = false; //false = player 1 turn, true = player 2 turn
        
        //Variables concerning the comparing and checking of cards
        PictureBox prev;
        byte flag = 0;

        //Initialize the game
        public game()
        {
            InitializeComponent();
            PlayerTurnLabel.Text = spelers.naam1 + " is aan de beurt."; //shows in a label who's turn it is
            timer1.Start(); //Starts the timer
        }
        //The actual timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer = Convert.ToInt32(TimerCounter.Text); //fills timer variable with text from timer label from form
            timer -= 1; //ticks the timer down by 1 
            TimerCounter.Text = Convert.ToString(timer); //converts the variable back to the text in timer label
            if (timer == 0) //if the timer reaches zero show message and stop timer
            {
                timer1.Stop();
                MessageBox.Show("Time's Up!");
            }
        }
        //still empty timers
        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }
        //Resets card images to cardback
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
        //Resets card tags
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
        //randomizes the cards
        void SetTagRandom()
        {
            int[] arr = new int[16]; //creates an array for the 16 cards
            int index = 0;
            Random rand = new Random(); //creates a random variable
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
        //Restart application
        private void opnieuw_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        //Go back to menu
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var game = new hoofdmenu();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }
        //Close application
        private void sluiten_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        //Compare selected cards
        public void Compare(PictureBox previous, PictureBox current)
        {
            if (previous.Tag.ToString() == current.Tag.ToString())
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                previous.Visible = false;
                current.Visible = false;
                
                pairsLeft--;
                Points();

                if(pairsLeft <= 0)
                {
                    if (playerScore1 > playerScore2)
                        MessageBox.Show(spelers.naam1 + " Has no life.");
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
