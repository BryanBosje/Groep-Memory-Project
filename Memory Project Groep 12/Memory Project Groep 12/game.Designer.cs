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
            this.terug = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.opnieuw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // terug
            // 
            this.terug.Location = new System.Drawing.Point(529, 327);
            this.terug.Name = "terug";
            this.terug.Size = new System.Drawing.Size(75, 47);
            this.terug.TabIndex = 10;
            this.terug.Text = "Terug";
            this.terug.UseVisualStyleBackColor = true;
            this.terug.Click += new System.EventHandler(this.terug_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(529, 380);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 47);
            this.quit.TabIndex = 9;
            this.quit.Text = "Game verlaten";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // opnieuw
            // 
            this.opnieuw.Location = new System.Drawing.Point(529, 274);
            this.opnieuw.Name = "opnieuw";
            this.opnieuw.Size = new System.Drawing.Size(75, 47);
            this.opnieuw.TabIndex = 11;
            this.opnieuw.Text = "Opnieuw";
            this.opnieuw.UseVisualStyleBackColor = true;
            this.opnieuw.Click += new System.EventHandler(this.opnieuw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 13;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opnieuw);
            this.Controls.Add(this.terug);
            this.Controls.Add(this.quit);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}