﻿namespace Memory_Project_Groep_12
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
            this.quit = new System.Windows.Forms.Button();
            this.terug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(778, 519);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 47);
            this.quit.TabIndex = 5;
            this.quit.Text = "Game verlaten";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // terug
            // 
            this.terug.Location = new System.Drawing.Point(778, 466);
            this.terug.Name = "terug";
            this.terug.Size = new System.Drawing.Size(75, 47);
            this.terug.TabIndex = 6;
            this.terug.Text = "Terug";
            this.terug.UseVisualStyleBackColor = true;
            this.terug.Click += new System.EventHandler(this.terug_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 578);
            this.Controls.Add(this.terug);
            this.Controls.Add(this.quit);
            this.MaximizeBox = false;
            this.Name = "game";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button terug;
    }
}