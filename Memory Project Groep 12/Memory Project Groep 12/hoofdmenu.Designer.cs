namespace Memory_Project_Groep_12
{
    partial class hoofdmenu
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
            this.play = new System.Windows.Forms.Button();
            this.highscores = new System.Windows.Forms.Button();
            this.over = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.muteUnmute = new System.Windows.Forms.CheckBox();
<<<<<<< HEAD
            this.starwars = new System.Windows.Forms.Button();
            this.auto = new System.Windows.Forms.Button();
            this.Standaard = new System.Windows.Forms.Button();
            this.frozen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
=======
>>>>>>> bryan
            this.SuspendLayout();
            // 
            // play
            // 
<<<<<<< HEAD
            this.play.Location = new System.Drawing.Point(226, 20);
            this.play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.play.Location = new System.Drawing.Point(139, 62);
            this.play.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> bryan
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(120, 37);
            this.play.TabIndex = 0;
            this.play.Text = "Start game";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
<<<<<<< HEAD
            // highscores
            // 
            this.highscores.Location = new System.Drawing.Point(226, 81);
            this.highscores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            // opties
            // 
            this.opties.Location = new System.Drawing.Point(139, 111);
            this.opties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.opties.Name = "opties";
            this.opties.Size = new System.Drawing.Size(120, 37);
            this.opties.TabIndex = 1;
            this.opties.Text = "Opties";
            this.opties.UseVisualStyleBackColor = true;
            this.opties.Click += new System.EventHandler(this.opties_Click);
            // 
            // highscores
            // 
            this.highscores.Location = new System.Drawing.Point(139, 163);
            this.highscores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> bryan
            this.highscores.Name = "highscores";
            this.highscores.Size = new System.Drawing.Size(120, 37);
            this.highscores.TabIndex = 2;
            this.highscores.Text = "Highscores";
            this.highscores.UseVisualStyleBackColor = true;
            this.highscores.Click += new System.EventHandler(this.highscores_Click);
            // 
            // over
            // 
<<<<<<< HEAD
            this.over.Location = new System.Drawing.Point(226, 146);
            this.over.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.over.Location = new System.Drawing.Point(139, 216);
            this.over.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> bryan
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(120, 37);
            this.over.TabIndex = 3;
            this.over.Text = "Over";
            this.over.UseVisualStyleBackColor = true;
            this.over.Click += new System.EventHandler(this.over_Click);
            // 
            // quit
            // 
<<<<<<< HEAD
            this.quit.Location = new System.Drawing.Point(529, 380);
            this.quit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.quit.Location = new System.Drawing.Point(397, 309);
            this.quit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> bryan
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(56, 38);
            this.quit.TabIndex = 4;
            this.quit.Text = "Game verlaten";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // muteUnmute
            // 
            this.muteUnmute.AutoSize = true;
<<<<<<< HEAD
            this.muteUnmute.Location = new System.Drawing.Point(17, 404);
            this.muteUnmute.Margin = new System.Windows.Forms.Padding(4);
            this.muteUnmute.Name = "muteUnmute";
            this.muteUnmute.Size = new System.Drawing.Size(101, 21);
=======
            this.muteUnmute.Location = new System.Drawing.Point(13, 328);
            this.muteUnmute.Name = "muteUnmute";
            this.muteUnmute.Size = new System.Drawing.Size(80, 17);
>>>>>>> bryan
            this.muteUnmute.TabIndex = 5;
            this.muteUnmute.Text = "Mute Audio";
            this.muteUnmute.UseVisualStyleBackColor = true;
            this.muteUnmute.CheckedChanged += new System.EventHandler(this.muteUnmute_CheckedChanged);
            // 
<<<<<<< HEAD
            // starwars
            // 
            this.starwars.Location = new System.Drawing.Point(225, 259);
            this.starwars.Name = "starwars";
            this.starwars.Size = new System.Drawing.Size(90, 46);
            this.starwars.TabIndex = 30;
            this.starwars.Text = "STAR WARS";
            this.starwars.UseVisualStyleBackColor = true;
            this.starwars.Click += new System.EventHandler(this.starwars_Click);
            // 
            // auto
            // 
            this.auto.Location = new System.Drawing.Point(417, 259);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(90, 46);
            this.auto.TabIndex = 29;
            this.auto.Text = "AUTO\'S";
            this.auto.UseVisualStyleBackColor = true;
            this.auto.Click += new System.EventHandler(this.auto_Click);
            // 
            // Standaard
            // 
            this.Standaard.Location = new System.Drawing.Point(116, 259);
            this.Standaard.Name = "Standaard";
            this.Standaard.Size = new System.Drawing.Size(103, 46);
            this.Standaard.TabIndex = 28;
            this.Standaard.Text = "STANDAARD";
            this.Standaard.UseVisualStyleBackColor = true;
            this.Standaard.Click += new System.EventHandler(this.Standaard_Click);
            // 
            // frozen
            // 
            this.frozen.Location = new System.Drawing.Point(321, 259);
            this.frozen.Name = "frozen";
            this.frozen.Size = new System.Drawing.Size(90, 46);
            this.frozen.TabIndex = 27;
            this.frozen.Text = "FROZEN";
            this.frozen.UseVisualStyleBackColor = true;
            this.frozen.Click += new System.EventHandler(this.frozen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Thema\'s";
            // 
=======
>>>>>>> bryan
            // hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(616, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.starwars);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.Standaard);
            this.Controls.Add(this.frozen);
=======
            this.ClientSize = new System.Drawing.Size(462, 357);
>>>>>>> bryan
            this.Controls.Add(this.muteUnmute);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.over);
            this.Controls.Add(this.highscores);
            this.Controls.Add(this.play);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> bryan
            this.MaximizeBox = false;
            this.Name = "hoofdmenu";
            this.Text = "Memory - menu";
            this.Load += new System.EventHandler(this.hoofdmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button highscores;
        private System.Windows.Forms.Button over;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.CheckBox muteUnmute;
<<<<<<< HEAD
        private System.Windows.Forms.Button starwars;
        private System.Windows.Forms.Button auto;
        private System.Windows.Forms.Button Standaard;
        private System.Windows.Forms.Button frozen;
        private System.Windows.Forms.Label label1;
=======
>>>>>>> bryan
    }
}

