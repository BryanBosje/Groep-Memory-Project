namespace Memory_Project_Groep_12
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
            this.NaamList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // terug
            // 
            this.terug.Location = new System.Drawing.Point(397, 266);
            this.terug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.terug.Name = "terug";
            this.terug.Size = new System.Drawing.Size(56, 38);
            this.terug.TabIndex = 8;
            this.terug.Text = "Terug";
            this.terug.UseVisualStyleBackColor = true;
            this.terug.Click += new System.EventHandler(this.terug_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(397, 309);
            this.quit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(56, 38);
            this.quit.TabIndex = 7;
            this.quit.Text = "Game verlaten";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // NaamList
            // 
            this.NaamList.FormattingEnabled = true;
            this.NaamList.Location = new System.Drawing.Point(12, 12);
            this.NaamList.Name = "NaamList";
            this.NaamList.Size = new System.Drawing.Size(64, 121);
            this.NaamList.TabIndex = 16;
            // 
            // Highscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 357);
            this.Controls.Add(this.NaamList);
            this.Controls.Add(this.terug);
            this.Controls.Add(this.quit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Highscores";
            this.Text = "Memory - highscores";
            this.Load += new System.EventHandler(this.Highscores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button terug;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.ListBox NaamList;
    }
}