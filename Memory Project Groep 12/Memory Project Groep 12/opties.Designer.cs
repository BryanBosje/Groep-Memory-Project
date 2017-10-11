namespace Memory_Project_Groep_12
{
    partial class opties
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
<<<<<<< HEAD
            this.terug.Location = new System.Drawing.Point(386, 277);
            this.terug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.terug.Name = "terug";
            this.terug.Size = new System.Drawing.Size(56, 38);
=======
            this.terug.Location = new System.Drawing.Point(515, 341);
            this.terug.Name = "terug";
            this.terug.Size = new System.Drawing.Size(75, 47);
>>>>>>> 06983b7a02f2ca4a9b65cddddcb7a7574a0ea3f6
            this.terug.TabIndex = 8;
            this.terug.Text = "Terug";
            this.terug.UseVisualStyleBackColor = true;
            this.terug.Click += new System.EventHandler(this.terug_Click);
            // 
            // quit
            // 
<<<<<<< HEAD
            this.quit.Location = new System.Drawing.Point(386, 320);
            this.quit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(56, 38);
=======
            this.quit.Location = new System.Drawing.Point(515, 394);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 47);
>>>>>>> 06983b7a02f2ca4a9b65cddddcb7a7574a0ea3f6
            this.quit.TabIndex = 7;
            this.quit.Text = "Game verlaten";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // opties
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 366);
            this.Controls.Add(this.terug);
            this.Controls.Add(this.quit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "opties";
            this.Text = "opties";
            this.Load += new System.EventHandler(this.opties_Load);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.terug);
            this.Controls.Add(this.quit);
            this.MaximizeBox = false;
            this.Name = "opties";
            this.Text = "opties";
>>>>>>> 06983b7a02f2ca4a9b65cddddcb7a7574a0ea3f6
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button terug;
        private System.Windows.Forms.Button quit;
    }
}