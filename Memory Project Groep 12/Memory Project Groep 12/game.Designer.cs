namespace Memory_Project_Groep_12
{
    partial class game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.quit = new System.Windows.Forms.Button();
            this.terug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreCounter = new System.Windows.Forms.Label();
            this.CardsHolder = new System.Windows.Forms.Panel();
            this.pictureBoxDup8 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDup7 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDup6 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDup5 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDup4 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDup3 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDup2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDup1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.CountDown = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.CardsHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(750, 556);
            this.quit.Margin = new System.Windows.Forms.Padding(2);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(56, 38);
            this.quit.TabIndex = 5;
            this.quit.Text = "Game verlaten";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // terug
            // 
            this.terug.Location = new System.Drawing.Point(750, 514);
            this.terug.Margin = new System.Windows.Forms.Padding(2);
            this.terug.Name = "terug";
            this.terug.Size = new System.Drawing.Size(56, 38);
            this.terug.TabIndex = 6;
            this.terug.Text = "Terug";
            this.terug.UseVisualStyleBackColor = true;
            this.terug.Click += new System.EventHandler(this.terug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(659, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Score:";
            // 
            // ScoreCounter
            // 
            this.ScoreCounter.AutoSize = true;
            this.ScoreCounter.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCounter.Location = new System.Drawing.Point(731, 9);
            this.ScoreCounter.Name = "ScoreCounter";
            this.ScoreCounter.Size = new System.Drawing.Size(21, 23);
            this.ScoreCounter.TabIndex = 24;
            this.ScoreCounter.Text = "0";
            // 
            // CardsHolder
            // 
            this.CardsHolder.Controls.Add(this.pictureBoxDup8);
            this.CardsHolder.Controls.Add(this.pictureBox8);
            this.CardsHolder.Controls.Add(this.pictureBoxDup7);
            this.CardsHolder.Controls.Add(this.pictureBox7);
            this.CardsHolder.Controls.Add(this.pictureBoxDup6);
            this.CardsHolder.Controls.Add(this.pictureBox6);
            this.CardsHolder.Controls.Add(this.pictureBoxDup5);
            this.CardsHolder.Controls.Add(this.pictureBox5);
            this.CardsHolder.Controls.Add(this.pictureBoxDup4);
            this.CardsHolder.Controls.Add(this.pictureBox4);
            this.CardsHolder.Controls.Add(this.pictureBoxDup3);
            this.CardsHolder.Controls.Add(this.pictureBox3);
            this.CardsHolder.Controls.Add(this.pictureBoxDup2);
            this.CardsHolder.Controls.Add(this.pictureBox2);
            this.CardsHolder.Controls.Add(this.pictureBoxDup1);
            this.CardsHolder.Controls.Add(this.pictureBox1);
            this.CardsHolder.Location = new System.Drawing.Point(0, 0);
            this.CardsHolder.Name = "CardsHolder";
            this.CardsHolder.Size = new System.Drawing.Size(653, 608);
            this.CardsHolder.TabIndex = 25;
            // 
            // pictureBoxDup8
            // 
            this.pictureBoxDup8.Location = new System.Drawing.Point(490, 458);
            this.pictureBoxDup8.Name = "pictureBoxDup8";
            this.pictureBoxDup8.Size = new System.Drawing.Size(155, 145);
            this.pictureBoxDup8.TabIndex = 38;
            this.pictureBoxDup8.TabStop = false;
            this.pictureBoxDup8.Tag = "8";
            this.pictureBoxDup8.Click += new System.EventHandler(this.pictureBoxDup8_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(329, 458);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(155, 145);
            this.pictureBox8.TabIndex = 37;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "8";
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBoxDup7
            // 
            this.pictureBoxDup7.Location = new System.Drawing.Point(168, 458);
            this.pictureBoxDup7.Name = "pictureBoxDup7";
            this.pictureBoxDup7.Size = new System.Drawing.Size(155, 145);
            this.pictureBoxDup7.TabIndex = 36;
            this.pictureBoxDup7.TabStop = false;
            this.pictureBoxDup7.Tag = "7";
            this.pictureBoxDup7.Click += new System.EventHandler(this.pictureBoxDup7_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(7, 458);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(155, 145);
            this.pictureBox7.TabIndex = 35;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "7";
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBoxDup6
            // 
            this.pictureBoxDup6.Location = new System.Drawing.Point(490, 307);
            this.pictureBoxDup6.Name = "pictureBoxDup6";
            this.pictureBoxDup6.Size = new System.Drawing.Size(155, 145);
            this.pictureBoxDup6.TabIndex = 34;
            this.pictureBoxDup6.TabStop = false;
            this.pictureBoxDup6.Tag = "6";
            this.pictureBoxDup6.Click += new System.EventHandler(this.pictureBoxDup6_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(329, 307);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(155, 145);
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "6";
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBoxDup5
            // 
            this.pictureBoxDup5.Location = new System.Drawing.Point(168, 307);
            this.pictureBoxDup5.Name = "pictureBoxDup5";
            this.pictureBoxDup5.Size = new System.Drawing.Size(155, 145);
            this.pictureBoxDup5.TabIndex = 32;
            this.pictureBoxDup5.TabStop = false;
            this.pictureBoxDup5.Tag = "5";
            this.pictureBoxDup5.Click += new System.EventHandler(this.pictureBoxDup5_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(7, 307);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(155, 145);
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "5";
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBoxDup4
            // 
            this.pictureBoxDup4.Location = new System.Drawing.Point(490, 156);
            this.pictureBoxDup4.Name = "pictureBoxDup4";
            this.pictureBoxDup4.Size = new System.Drawing.Size(155, 145);
            this.pictureBoxDup4.TabIndex = 30;
            this.pictureBoxDup4.TabStop = false;
            this.pictureBoxDup4.Tag = "4";
            this.pictureBoxDup4.Click += new System.EventHandler(this.pictureBoxDup4_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(329, 156);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(155, 145);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "4";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBoxDup3
            // 
            this.pictureBoxDup3.Location = new System.Drawing.Point(168, 156);
            this.pictureBoxDup3.Name = "pictureBoxDup3";
            this.pictureBoxDup3.Size = new System.Drawing.Size(155, 145);
            this.pictureBoxDup3.TabIndex = 28;
            this.pictureBoxDup3.TabStop = false;
            this.pictureBoxDup3.Tag = "3";
            this.pictureBoxDup3.Click += new System.EventHandler(this.pictureBoxDup3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(7, 156);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 145);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "3";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBoxDup2
            // 
            this.pictureBoxDup2.Location = new System.Drawing.Point(490, 5);
            this.pictureBoxDup2.Name = "pictureBoxDup2";
            this.pictureBoxDup2.Size = new System.Drawing.Size(155, 145);
            this.pictureBoxDup2.TabIndex = 26;
            this.pictureBoxDup2.TabStop = false;
            this.pictureBoxDup2.Tag = "2";
            this.pictureBoxDup2.Click += new System.EventHandler(this.pictureBoxDup2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(329, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 145);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "2";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxDup1
            // 
            this.pictureBoxDup1.Location = new System.Drawing.Point(168, 5);
            this.pictureBoxDup1.Name = "pictureBoxDup1";
            this.pictureBoxDup1.Size = new System.Drawing.Size(155, 145);
            this.pictureBoxDup1.TabIndex = 24;
            this.pictureBoxDup1.TabStop = false;
            this.pictureBoxDup1.Tag = "1";
            this.pictureBoxDup1.Click += new System.EventHandler(this.pictureBoxDup1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 145);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CountDown
            // 
            this.CountDown.AutoSize = true;
            this.CountDown.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDown.Location = new System.Drawing.Point(732, 47);
            this.CountDown.Name = "CountDown";
            this.CountDown.Size = new System.Drawing.Size(19, 23);
            this.CountDown.TabIndex = 26;
            this.CountDown.Text = "3";
            this.CountDown.Click += new System.EventHandler(this.CountDown_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 300;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 620);
            this.Controls.Add(this.CountDown);
            this.Controls.Add(this.CardsHolder);
            this.Controls.Add(this.ScoreCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.terug);
            this.Controls.Add(this.quit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "16";
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.game_Load);
            this.CardsHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button terug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScoreCounter;
        private System.Windows.Forms.Panel CardsHolder;
        private System.Windows.Forms.PictureBox pictureBoxDup8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBoxDup7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBoxDup6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBoxDup5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBoxDup4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBoxDup3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxDup2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxDup1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label CountDown;
        private System.Windows.Forms.Timer timer3;
    }
}