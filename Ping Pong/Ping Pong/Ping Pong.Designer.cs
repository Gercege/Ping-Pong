namespace Ping_Pong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel = new Panel();
            balla = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            racketa = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            scorea = new Label();
            scoretext = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)balla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)racketa).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(balla);
            panel.Controls.Add(label9);
            panel.Controls.Add(label8);
            panel.Controls.Add(racketa);
            panel.Controls.Add(label7);
            panel.Controls.Add(label6);
            panel.Controls.Add(label5);
            panel.Controls.Add(label4);
            panel.Controls.Add(label3);
            panel.Controls.Add(scorea);
            panel.Controls.Add(scoretext);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(1923, 673);
            panel.TabIndex = 0;
            // 
            // balla
            // 
            balla.BackColor = Color.Red;
            balla.Location = new Point(129, 107);
            balla.Name = "balla";
            balla.Size = new Size(26, 26);
            balla.TabIndex = 1;
            balla.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1787, 109);
            label9.Name = "label9";
            label9.Size = new Size(124, 24);
            label9.TabIndex = 10;
            label9.Text = "A-Move Left";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1773, 81);
            label8.Name = "label8";
            label8.Size = new Size(138, 24);
            label8.TabIndex = 9;
            label8.Text = "D-Move Right";
            // 
            // racketa
            // 
            racketa.BackColor = Color.Black;
            racketa.Location = new Point(380, 404);
            racketa.Name = "racketa";
            racketa.Size = new Size(351, 15);
            racketa.TabIndex = 0;
            racketa.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1645, 33);
            label7.Name = "label7";
            label7.Size = new Size(266, 24);
            label7.TabIndex = 8;
            label7.Text = "N-Change Color Of Racket ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1598, 9);
            label6.Name = "label6";
            label6.Size = new Size(313, 24);
            label6.TabIndex = 7;
            label6.Text = "M-Change Color Of Background";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1681, 57);
            label5.Name = "label5";
            label5.Size = new Size(230, 24);
            label5.TabIndex = 6;
            label5.Text = "B-Change Color Of Ball";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1823, 157);
            label4.Name = "label4";
            label4.Size = new Size(88, 24);
            label4.TabIndex = 5;
            label4.Text = "Esc-Exit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1811, 133);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 4;
            label3.Text = "R-Restart";
            // 
            // scorea
            // 
            scorea.AutoSize = true;
            scorea.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            scorea.Location = new Point(129, 9);
            scorea.Name = "scorea";
            scorea.Size = new Size(29, 32);
            scorea.TabIndex = 3;
            scorea.Text = "0";
            // 
            // scoretext
            // 
            scoretext.AutoSize = true;
            scoretext.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            scoretext.Location = new Point(12, 9);
            scoretext.Name = "scoretext";
            scoretext.Size = new Size(90, 32);
            scoretext.TabIndex = 2;
            scoretext.Text = "Score";
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1923, 673);
            Controls.Add(panel);
            Name = "Form1";
            Text = "Ping Pong";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)balla).EndInit();
            ((System.ComponentModel.ISupportInitialize)racketa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private PictureBox balla;
        private PictureBox racketa;
        private System.Windows.Forms.Timer timer1;
        private Label scoretext;
        private Label scorea;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
    }
}