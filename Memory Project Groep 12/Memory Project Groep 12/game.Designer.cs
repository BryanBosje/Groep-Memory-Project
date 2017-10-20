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
            this.terug = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.opnieuw = new System.Windows.Forms.Button();
            this.Naam = new System.Windows.Forms.Label();
            this.NaamInput = new System.Windows.Forms.TextBox();
            this.SaveNaam = new System.Windows.Forms.Button();
            this.NaamList = new System.Windows.Forms.ListBox();
            this.Highscore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // terug
            // 
            this.terug.Location = new System.Drawing.Point(391, 226);
            this.terug.Margin = new System.Windows.Forms.Padding(2);
            this.terug.Name = "terug";
            this.terug.Size = new System.Drawing.Size(64, 38);
            this.terug.TabIndex = 10;
            this.terug.Text = "Terug";
            this.terug.UseVisualStyleBackColor = true;
            this.terug.Click += new System.EventHandler(this.terug_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(391, 309);
            this.quit.Margin = new System.Windows.Forms.Padding(2);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(64, 38);
            this.quit.TabIndex = 9;
            this.quit.Text = "Game verlaten";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // opnieuw
            // 
            this.opnieuw.Location = new System.Drawing.Point(391, 184);
            this.opnieuw.Margin = new System.Windows.Forms.Padding(2);
            this.opnieuw.Name = "opnieuw";
            this.opnieuw.Size = new System.Drawing.Size(64, 38);
            this.opnieuw.TabIndex = 11;
            this.opnieuw.Text = "Opnieuw";
            this.opnieuw.UseVisualStyleBackColor = true;
            this.opnieuw.Click += new System.EventHandler(this.opnieuw_Click);
            // 
            // Naam
            // 
            this.Naam.AutoSize = true;
            this.Naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naam.Location = new System.Drawing.Point(387, 9);
            this.Naam.Name = "Naam";
            this.Naam.Size = new System.Drawing.Size(55, 20);
            this.Naam.TabIndex = 12;
            this.Naam.Text = "Naam:";
            // 
            // NaamInput
            // 
            this.NaamInput.Location = new System.Drawing.Point(391, 32);
            this.NaamInput.Name = "NaamInput";
            this.NaamInput.Size = new System.Drawing.Size(64, 20);
            this.NaamInput.TabIndex = 13;
            // 
            // SaveNaam
            // 
            this.SaveNaam.Location = new System.Drawing.Point(391, 58);
            this.SaveNaam.Name = "SaveNaam";
            this.SaveNaam.Size = new System.Drawing.Size(64, 23);
            this.SaveNaam.TabIndex = 14;
            this.SaveNaam.Text = "Save";
            this.SaveNaam.UseVisualStyleBackColor = true;
            this.SaveNaam.Click += new System.EventHandler(this.SaveNaam_Click);
            // 
            // NaamList
            // 
            this.NaamList.FormattingEnabled = true;
            this.NaamList.Location = new System.Drawing.Point(12, 184);
            this.NaamList.Name = "NaamList";
            this.NaamList.Size = new System.Drawing.Size(64, 160);
            this.NaamList.TabIndex = 15;
            // 
            // Highscore
            // 
            this.Highscore.Location = new System.Drawing.Point(391, 269);
            this.Highscore.Name = "Highscore";
            this.Highscore.Size = new System.Drawing.Size(64, 35);
            this.Highscore.TabIndex = 16;
            this.Highscore.Text = "Highscore";
            this.Highscore.UseVisualStyleBackColor = true;
            this.Highscore.Click += new System.EventHandler(this.Highscore_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 357);
            this.Controls.Add(this.Highscore);
            this.Controls.Add(this.NaamList);
            this.Controls.Add(this.SaveNaam);
            this.Controls.Add(this.NaamInput);
            this.Controls.Add(this.Naam);
            this.Controls.Add(this.opnieuw);
            this.Controls.Add(this.terug);
            this.Controls.Add(this.quit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "game";
            this.Text = "Memory - game";
            this.Load += new System.EventHandler(this.game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button terug;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button opnieuw;
        private System.Windows.Forms.Label Naam;
        private System.Windows.Forms.TextBox NaamInput;
        private System.Windows.Forms.Button SaveNaam;
        private System.Windows.Forms.ListBox NaamList;
        private System.Windows.Forms.Button Highscore;
    }
}