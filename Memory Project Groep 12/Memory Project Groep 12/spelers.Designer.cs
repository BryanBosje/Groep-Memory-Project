namespace Memory_Project_Groep_12
{
    partial class spelers
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
            this.tekst_speler1 = new System.Windows.Forms.TextBox();
            this.tekst_speler2 = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.speler1 = new System.Windows.Forms.Label();
            this.speler2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tekst_speler1
            // 
            this.tekst_speler1.Location = new System.Drawing.Point(167, 73);
            this.tekst_speler1.Name = "tekst_speler1";
            this.tekst_speler1.Size = new System.Drawing.Size(121, 22);
            this.tekst_speler1.TabIndex = 0;
            // 
            // tekst_speler2
            // 
            this.tekst_speler2.Location = new System.Drawing.Point(167, 115);
            this.tekst_speler2.Name = "tekst_speler2";
            this.tekst_speler2.Size = new System.Drawing.Size(121, 22);
            this.tekst_speler2.TabIndex = 1;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(167, 164);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(92, 31);
            this.start.TabIndex = 2;
            this.start.Text = "Spelen";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // speler1
            // 
            this.speler1.AutoSize = true;
            this.speler1.Location = new System.Drawing.Point(91, 77);
            this.speler1.Name = "speler1";
            this.speler1.Size = new System.Drawing.Size(61, 17);
            this.speler1.TabIndex = 3;
            this.speler1.Text = "Speler 1";
            // 
            // speler2
            // 
            this.speler2.AutoSize = true;
            this.speler2.Location = new System.Drawing.Point(94, 119);
            this.speler2.Name = "speler2";
            this.speler2.Size = new System.Drawing.Size(61, 17);
            this.speler2.TabIndex = 4;
            this.speler2.Text = "Speler 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Voer de spelersnamen in";
            // 
            // spelers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speler2);
            this.Controls.Add(this.speler1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.tekst_speler2);
            this.Controls.Add(this.tekst_speler1);
            this.Name = "spelers";
            this.Text = "spelers";
            this.Load += new System.EventHandler(this.spelers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tekst_speler1;
        private System.Windows.Forms.TextBox tekst_speler2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label speler1;
        private System.Windows.Forms.Label speler2;
        private System.Windows.Forms.Label label1;
    }
}