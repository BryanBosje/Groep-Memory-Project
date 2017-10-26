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
            this.label2 = new System.Windows.Forms.Label();
            this.speler2 = new System.Windows.Forms.Label();
            this.speler1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.tekst_speler2 = new System.Windows.Forms.TextBox();
            this.tekst_speler1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Voer de spelersnamen in";
            // 
            // speler2
            // 
            this.speler2.AutoSize = true;
            this.speler2.Location = new System.Drawing.Point(70, 90);
            this.speler2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speler2.Name = "speler2";
            this.speler2.Size = new System.Drawing.Size(46, 13);
            this.speler2.TabIndex = 10;
            this.speler2.Text = "Speler 2";
            // 
            // speler1
            // 
            this.speler1.AutoSize = true;
            this.speler1.Location = new System.Drawing.Point(68, 56);
            this.speler1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speler1.Name = "speler1";
            this.speler1.Size = new System.Drawing.Size(46, 13);
            this.speler1.TabIndex = 9;
            this.speler1.Text = "Speler 1";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(125, 126);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(69, 25);
            this.start.TabIndex = 8;
            this.start.Text = "Spelen";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // tekst_speler2
            // 
            this.tekst_speler2.Location = new System.Drawing.Point(125, 86);
            this.tekst_speler2.Margin = new System.Windows.Forms.Padding(2);
            this.tekst_speler2.Name = "tekst_speler2";
            this.tekst_speler2.Size = new System.Drawing.Size(92, 20);
            this.tekst_speler2.TabIndex = 7;
            // 
            // tekst_speler1
            // 
            this.tekst_speler1.Location = new System.Drawing.Point(125, 52);
            this.tekst_speler1.Margin = new System.Windows.Forms.Padding(2);
            this.tekst_speler1.Name = "tekst_speler1";
            this.tekst_speler1.Size = new System.Drawing.Size(92, 20);
            this.tekst_speler1.TabIndex = 6;
            // 
            // spelers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 162);
            this.Controls.Add(this.label2);
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label speler2;
        private System.Windows.Forms.Label speler1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox tekst_speler2;
        private System.Windows.Forms.TextBox tekst_speler1;
    }
}