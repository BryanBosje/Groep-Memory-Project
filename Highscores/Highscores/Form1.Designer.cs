namespace Highscores
{
    partial class Highscore
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
            this.Naam = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.NaamList = new System.Windows.Forms.ListBox();
            this.ScoreList = new System.Windows.Forms.ListBox();
            this.NaamInput = new System.Windows.Forms.TextBox();
            this.ScoreInput = new System.Windows.Forms.TextBox();
            this.SaveNaam = new System.Windows.Forms.Button();
            this.SaveScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Naam
            // 
            this.Naam.AutoSize = true;
            this.Naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naam.Location = new System.Drawing.Point(12, 10);
            this.Naam.Name = "Naam";
            this.Naam.Size = new System.Drawing.Size(64, 25);
            this.Naam.TabIndex = 0;
            this.Naam.Text = "Naam";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(228, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(64, 25);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score";
            // 
            // NaamList
            // 
            this.NaamList.FormattingEnabled = true;
            this.NaamList.Location = new System.Drawing.Point(12, 108);
            this.NaamList.Name = "NaamList";
            this.NaamList.Size = new System.Drawing.Size(194, 524);
            this.NaamList.TabIndex = 2;
            // 
            // ScoreList
            // 
            this.ScoreList.FormattingEnabled = true;
            this.ScoreList.Location = new System.Drawing.Point(233, 108);
            this.ScoreList.Name = "ScoreList";
            this.ScoreList.Size = new System.Drawing.Size(194, 524);
            this.ScoreList.TabIndex = 3;
            // 
            // NaamInput
            // 
            this.NaamInput.Location = new System.Drawing.Point(12, 44);
            this.NaamInput.Name = "NaamInput";
            this.NaamInput.Size = new System.Drawing.Size(194, 20);
            this.NaamInput.TabIndex = 4;
            // 
            // ScoreInput
            // 
            this.ScoreInput.Location = new System.Drawing.Point(233, 44);
            this.ScoreInput.Name = "ScoreInput";
            this.ScoreInput.Size = new System.Drawing.Size(194, 20);
            this.ScoreInput.TabIndex = 5;
            // 
            // SaveNaam
            // 
            this.SaveNaam.Location = new System.Drawing.Point(12, 70);
            this.SaveNaam.Name = "SaveNaam";
            this.SaveNaam.Size = new System.Drawing.Size(64, 23);
            this.SaveNaam.TabIndex = 6;
            this.SaveNaam.Text = "Save";
            this.SaveNaam.UseVisualStyleBackColor = true;
            this.SaveNaam.Click += new System.EventHandler(this.SaveNaam_Click);
            // 
            // SaveScore
            // 
            this.SaveScore.Location = new System.Drawing.Point(233, 70);
            this.SaveScore.Name = "SaveScore";
            this.SaveScore.Size = new System.Drawing.Size(64, 23);
            this.SaveScore.TabIndex = 7;
            this.SaveScore.Text = "Save";
            this.SaveScore.UseVisualStyleBackColor = true;
            this.SaveScore.Click += new System.EventHandler(this.SaveScore_Click);
            // 
            // Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 644);
            this.Controls.Add(this.SaveScore);
            this.Controls.Add(this.SaveNaam);
            this.Controls.Add(this.ScoreInput);
            this.Controls.Add(this.NaamInput);
            this.Controls.Add(this.ScoreList);
            this.Controls.Add(this.NaamList);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Naam);
            this.Name = "Highscore";
            this.Text = "Highscore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Naam;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.ListBox NaamList;
        private System.Windows.Forms.ListBox ScoreList;
        private System.Windows.Forms.TextBox NaamInput;
        private System.Windows.Forms.TextBox ScoreInput;
        private System.Windows.Forms.Button SaveNaam;
        private System.Windows.Forms.Button SaveScore;
    }
}

