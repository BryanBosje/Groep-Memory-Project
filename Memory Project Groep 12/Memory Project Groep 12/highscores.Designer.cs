﻿namespace Memory_Project_Groep_12
{
    partial class Highscores
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
            this.SuspendLayout();
            // 
            // terug
            // 
            this.terug.Location = new System.Drawing.Point(458, 367);
            this.terug.Name = "terug";
            this.terug.Size = new System.Drawing.Size(75, 47);
            this.terug.TabIndex = 8;
            this.terug.Text = "Terug";
            this.terug.UseVisualStyleBackColor = true;
            this.terug.Click += new System.EventHandler(this.terug_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(458, 420);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 47);
            this.quit.TabIndex = 7;
            this.quit.Text = "Game verlaten";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // Highscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 474);
            this.Controls.Add(this.terug);
            this.Controls.Add(this.quit);
            this.MaximizeBox = false;
            this.Name = "Highscores";
            this.Text = "Highscores";
            this.Load += new System.EventHandler(this.Highscores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button terug;
        private System.Windows.Forms.Button quit;
    }
}