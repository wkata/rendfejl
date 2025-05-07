namespace kliensalk
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rendszam = new System.Windows.Forms.Label();
            this.renddatum = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.megrendelesd = new System.Windows.Forms.Label();
            this.csomagolvad = new System.Windows.Forms.Label();
            this.postarad = new System.Windows.Forms.Label();
            this.kikuldesd = new System.Windows.Forms.Label();
            this.atveteld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(200, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kérem adja meg a rendelésének számát, amit e-mailben kapott meg";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Keresés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rendelés Száma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rendelés Várható Átvétele";
            // 
            // rendszam
            // 
            this.rendszam.AutoSize = true;
            this.rendszam.Location = new System.Drawing.Point(115, 94);
            this.rendszam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rendszam.Name = "rendszam";
            this.rendszam.Size = new System.Drawing.Size(14, 15);
            this.rendszam.TabIndex = 5;
            this.rendszam.Text = "0";
            // 
            // renddatum
            // 
            this.renddatum.AutoSize = true;
            this.renddatum.Location = new System.Drawing.Point(446, 94);
            this.renddatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.renddatum.Name = "renddatum";
            this.renddatum.Size = new System.Drawing.Size(69, 15);
            this.renddatum.TabIndex = 6;
            this.renddatum.Text = "2025.05.21";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(62, 218);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(465, 26);
            this.progressBar1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Megrendelés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Csomagolva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Postára feladva";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Csomag kiküldése";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(541, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Átvétel";
            // 
            // megrendelesd
            // 
            this.megrendelesd.AutoSize = true;
            this.megrendelesd.Location = new System.Drawing.Point(16, 173);
            this.megrendelesd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.megrendelesd.Name = "megrendelesd";
            this.megrendelesd.Size = new System.Drawing.Size(69, 15);
            this.megrendelesd.TabIndex = 13;
            this.megrendelesd.Text = "2025.04.11";
            // 
            // csomagolvad
            // 
            this.csomagolvad.AutoSize = true;
            this.csomagolvad.Location = new System.Drawing.Point(132, 173);
            this.csomagolvad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.csomagolvad.Name = "csomagolvad";
            this.csomagolvad.Size = new System.Drawing.Size(69, 15);
            this.csomagolvad.TabIndex = 14;
            this.csomagolvad.Text = "2025.04.12";
            // 
            // postarad
            // 
            this.postarad.AutoSize = true;
            this.postarad.Location = new System.Drawing.Point(260, 173);
            this.postarad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.postarad.Name = "postarad";
            this.postarad.Size = new System.Drawing.Size(69, 15);
            this.postarad.TabIndex = 15;
            this.postarad.Text = "2025.04.13";
            // 
            // kikuldesd
            // 
            this.kikuldesd.AutoSize = true;
            this.kikuldesd.Location = new System.Drawing.Point(401, 173);
            this.kikuldesd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kikuldesd.Name = "kikuldesd";
            this.kikuldesd.Size = new System.Drawing.Size(69, 15);
            this.kikuldesd.TabIndex = 16;
            this.kikuldesd.Text = "2025.05.13";
            // 
            // atveteld
            // 
            this.atveteld.AutoSize = true;
            this.atveteld.Location = new System.Drawing.Point(532, 173);
            this.atveteld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.atveteld.Name = "atveteld";
            this.atveteld.Size = new System.Drawing.Size(69, 15);
            this.atveteld.TabIndex = 17;
            this.atveteld.Text = "2025.05.21";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 255);
            this.Controls.Add(this.atveteld);
            this.Controls.Add(this.kikuldesd);
            this.Controls.Add(this.postarad);
            this.Controls.Add(this.csomagolvad);
            this.Controls.Add(this.megrendelesd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.renddatum);
            this.Controls.Add(this.rendszam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rendszam;
        private System.Windows.Forms.Label renddatum;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label megrendelesd;
        private System.Windows.Forms.Label csomagolvad;
        private System.Windows.Forms.Label postarad;
        private System.Windows.Forms.Label kikuldesd;
        private System.Windows.Forms.Label atveteld;
    }
}

