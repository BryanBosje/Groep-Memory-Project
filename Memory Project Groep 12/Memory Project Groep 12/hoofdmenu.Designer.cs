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
            this.opties = new System.Windows.Forms.Button();
            this.highscores = new System.Windows.Forms.Button();
            this.over = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.muteUnmute = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(139, 62);
            this.play.Margin = new System.Windows.Forms.Padding(2);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(120, 37);
            this.play.TabIndex = 0;
            this.play.Text = "Start game";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // opties
            // 
            this.opties.Location = new System.Drawing.Point(139, 111);
            this.opties.Margin = new System.Windows.Forms.Padding(2);
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
            this.highscores.Margin = new System.Windows.Forms.Padding(2);
            this.highscores.Name = "highscores";
            this.highscores.Size = new System.Drawing.Size(120, 37);
            this.highscores.TabIndex = 2;
            this.highscores.Text = "Highscores";
            this.highscores.UseVisualStyleBackColor = true;
            this.highscores.Click += new System.EventHandler(this.highscores_Click);
            // 
            // over
            // 
            this.over.Location = new System.Drawing.Point(139, 216);
            this.over.Margin = new System.Windows.Forms.Padding(2);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(120, 37);
            this.over.TabIndex = 3;
            this.over.Text = "Over";
            this.over.UseVisualStyleBackColor = true;
            this.over.Click += new System.EventHandler(this.over_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(397, 309);
            this.quit.Margin = new System.Windows.Forms.Padding(2);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(56, 38);
            this.quit.TabIndex = 4;
            this.quit.Text = "Game verlaten";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // muteUnmute
            // 
            this.muteUnmute.Appearance = System.Windows.Forms.Appearance.Button;
            this.muteUnmute.AutoSize = true;
            this.muteUnmute.Location = new System.Drawing.Point(12, 324);
            this.muteUnmute.Name = "muteUnmute";
            this.muteUnmute.Size = new System.Drawing.Size(71, 23);
            this.muteUnmute.TabIndex = 5;
            this.muteUnmute.Text = "Mute Audio";
            this.muteUnmute.UseVisualStyleBackColor = true;
            this.muteUnmute.CheckedChanged += new System.EventHandler(this.muteUnmute_CheckedChanged);
            // 
            // hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 357);
            this.Controls.Add(this.muteUnmute);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.over);
            this.Controls.Add(this.highscores);
            this.Controls.Add(this.opties);
            this.Controls.Add(this.play);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "hoofdmenu";
            this.Text = "Hoofdmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button opties;
        private System.Windows.Forms.Button highscores;
        private System.Windows.Forms.Button over;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.CheckBox muteUnmute;
    }
}

