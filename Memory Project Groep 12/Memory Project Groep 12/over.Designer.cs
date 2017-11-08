namespace Memory_Project_Groep_12
{
    partial class over
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
            this.label1 = new System.Windows.Forms.Label();
            this.naam1 = new System.Windows.Forms.Label();
            this.naam2 = new System.Windows.Forms.Label();
            this.naam3 = new System.Windows.Forms.Label();
            this.naam4 = new System.Windows.Forms.Label();
            this.naam5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // terug
            // 
            this.terug.Location = new System.Drawing.Point(529, 327);
            this.terug.Name = "terug";
            this.terug.Size = new System.Drawing.Size(75, 47);
            this.terug.TabIndex = 8;
            this.terug.Text = "Terug";
            this.terug.UseVisualStyleBackColor = true;
            this.terug.Click += new System.EventHandler(this.terug_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(529, 380);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 47);
            this.quit.TabIndex = 7;
            this.quit.Text = "Game verlaten";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Deze game is mede mogelijk gemaakt door";
            // 
            // naam1
            // 
            this.naam1.AutoSize = true;
            this.naam1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naam1.Location = new System.Drawing.Point(195, 101);
            this.naam1.Name = "naam1";
            this.naam1.Size = new System.Drawing.Size(179, 41);
            this.naam1.TabIndex = 10;
            this.naam1.Text = "Léon Linders";
            // 
            // naam2
            // 
            this.naam2.AutoSize = true;
            this.naam2.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naam2.Location = new System.Drawing.Point(195, 153);
            this.naam2.Name = "naam2";
            this.naam2.Size = new System.Drawing.Size(144, 41);
            this.naam2.TabIndex = 11;
            this.naam2.Text = "Bryan Bos";
            // 
            // naam3
            // 
            this.naam3.AutoSize = true;
            this.naam3.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naam3.Location = new System.Drawing.Point(195, 202);
            this.naam3.Name = "naam3";
            this.naam3.Size = new System.Drawing.Size(172, 41);
            this.naam3.TabIndex = 12;
            this.naam3.Text = "Jordy Bosma";
            // 
            // naam4
            // 
            this.naam4.AutoSize = true;
            this.naam4.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naam4.Location = new System.Drawing.Point(195, 257);
            this.naam4.Name = "naam4";
            this.naam4.Size = new System.Drawing.Size(201, 41);
            this.naam4.TabIndex = 13;
            this.naam4.Text = "Sietse Leenstra";
            // 
            // naam5
            // 
            this.naam5.AutoSize = true;
            this.naam5.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naam5.Location = new System.Drawing.Point(195, 306);
            this.naam5.Name = "naam5";
            this.naam5.Size = new System.Drawing.Size(186, 41);
            this.naam5.TabIndex = 14;
            this.naam5.Text = "Dennis Runia";
            // 
            // over
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 439);
            this.Controls.Add(this.naam5);
            this.Controls.Add(this.naam4);
            this.Controls.Add(this.naam3);
            this.Controls.Add(this.naam2);
            this.Controls.Add(this.naam1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.terug);
            this.Controls.Add(this.quit);
            this.MaximizeBox = false;
            this.Name = "over";
            this.Text = "Memory - over";
            this.Load += new System.EventHandler(this.over_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button terug;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label naam1;
        private System.Windows.Forms.Label naam2;
        private System.Windows.Forms.Label naam3;
        private System.Windows.Forms.Label naam4;
        private System.Windows.Forms.Label naam5;
    }
}