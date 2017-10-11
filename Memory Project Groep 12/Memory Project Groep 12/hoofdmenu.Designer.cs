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
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(185, 76);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(160, 46);
            this.play.TabIndex = 0;
            this.play.Text = "Start game";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // opties
            // 
            this.opties.Location = new System.Drawing.Point(185, 137);
            this.opties.Name = "opties";
            this.opties.Size = new System.Drawing.Size(160, 46);
            this.opties.TabIndex = 1;
            this.opties.Text = "Opties";
            this.opties.UseVisualStyleBackColor = true;
            this.opties.Click += new System.EventHandler(this.opties_Click);
            // 
            // highscores
            // 
            this.highscores.Location = new System.Drawing.Point(185, 201);
            this.highscores.Name = "highscores";
            this.highscores.Size = new System.Drawing.Size(160, 46);
            this.highscores.TabIndex = 2;
            this.highscores.Text = "Highscores";
            this.highscores.UseVisualStyleBackColor = true;
            this.highscores.Click += new System.EventHandler(this.highscores_Click);
            // 
            // over
            // 
            this.over.Location = new System.Drawing.Point(185, 266);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(160, 46);
            this.over.TabIndex = 3;
            this.over.Text = "Over";
            this.over.UseVisualStyleBackColor = true;
            this.over.Click += new System.EventHandler(this.over_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(529, 380);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 47);
            this.quit.TabIndex = 4;
            this.quit.Text = "Game verlaten";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 439);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.over);
            this.Controls.Add(this.highscores);
            this.Controls.Add(this.opties);
            this.Controls.Add(this.play);
            this.MaximizeBox = false;
            this.Name = "hoofdmenu";
            this.Text = "Hoofdmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button opties;
        private System.Windows.Forms.Button highscores;
        private System.Windows.Forms.Button over;
        private System.Windows.Forms.Button quit;
    }
}

