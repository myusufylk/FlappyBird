namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Flying_timer1 = new System.Windows.Forms.Timer(this.components);
            this.Fall_Down_timer1 = new System.Windows.Forms.Timer(this.components);
            this.Moving_Pipes_timer1 = new System.Windows.Forms.Timer(this.components);
            this.FlappyBird_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GameOver_label1 = new System.Windows.Forms.Label();
            this.NewGame_label1 = new System.Windows.Forms.Label();
            this.FinalScore_label1 = new System.Windows.Forms.Label();
            this.Score_label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Flying_timer1
            // 
            this.Flying_timer1.Enabled = true;
            this.Flying_timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Fall_Down_timer1
            // 
            this.Fall_Down_timer1.Enabled = true;
            this.Fall_Down_timer1.Tick += new System.EventHandler(this.Fall_Down_timer1_Tick);
            // 
            // Moving_Pipes_timer1
            // 
            this.Moving_Pipes_timer1.Enabled = true;
            this.Moving_Pipes_timer1.Interval = 50;
            this.Moving_Pipes_timer1.Tick += new System.EventHandler(this.Moving_Pipes_timer1_Tick);
            // 
            // FlappyBird_pictureBox1
            // 
            this.FlappyBird_pictureBox1.Image = global::FlappyBird.Properties.Resources.FlappyBird;
            this.FlappyBird_pictureBox1.Location = new System.Drawing.Point(47, 211);
            this.FlappyBird_pictureBox1.Name = "FlappyBird_pictureBox1";
            this.FlappyBird_pictureBox1.Size = new System.Drawing.Size(170, 120);
            this.FlappyBird_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird_pictureBox1.TabIndex = 0;
            this.FlappyBird_pictureBox1.TabStop = false;
            this.FlappyBird_pictureBox1.Click += new System.EventHandler(this.FlappyBird_pictureBox1_Click);
            // 
            // GameOver_label1
            // 
            this.GameOver_label1.AutoSize = true;
            this.GameOver_label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GameOver_label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOver_label1.ForeColor = System.Drawing.Color.Black;
            this.GameOver_label1.Location = new System.Drawing.Point(423, 269);
            this.GameOver_label1.Name = "GameOver_label1";
            this.GameOver_label1.Size = new System.Drawing.Size(199, 39);
            this.GameOver_label1.TabIndex = 1;
            this.GameOver_label1.Text = "GAME OVER";
            this.GameOver_label1.Visible = false;
            // 
            // NewGame_label1
            // 
            this.NewGame_label1.AutoSize = true;
            this.NewGame_label1.BackColor = System.Drawing.Color.Lime;
            this.NewGame_label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewGame_label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame_label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NewGame_label1.Location = new System.Drawing.Point(430, 374);
            this.NewGame_label1.Name = "NewGame_label1";
            this.NewGame_label1.Size = new System.Drawing.Size(192, 41);
            this.NewGame_label1.TabIndex = 2;
            this.NewGame_label1.Text = "NEW GAME";
            this.NewGame_label1.Visible = false;
            this.NewGame_label1.Click += new System.EventHandler(this.NewGame_label1_Click);
            this.NewGame_label1.MouseLeave += new System.EventHandler(this.NewGame_label1_MouseLeave);
            this.NewGame_label1.MouseHover += new System.EventHandler(this.NewGame_label1_MouseHover);
            // 
            // FinalScore_label1
            // 
            this.FinalScore_label1.AutoSize = true;
            this.FinalScore_label1.BackColor = System.Drawing.Color.White;
            this.FinalScore_label1.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalScore_label1.Location = new System.Drawing.Point(413, 321);
            this.FinalScore_label1.Name = "FinalScore_label1";
            this.FinalScore_label1.Size = new System.Drawing.Size(220, 37);
            this.FinalScore_label1.TabIndex = 3;
            this.FinalScore_label1.Text = "Your Score:0";
            this.FinalScore_label1.Visible = false;
            // 
            // Score_label1
            // 
            this.Score_label1.AutoSize = true;
            this.Score_label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(195)))), ((int)(((byte)(205)))));
            this.Score_label1.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Score_label1.Location = new System.Drawing.Point(934, 9);
            this.Score_label1.Name = "Score_label1";
            this.Score_label1.Size = new System.Drawing.Size(36, 37);
            this.Score_label1.TabIndex = 4;
            this.Score_label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(195)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(999, 761);
            this.Controls.Add(this.Score_label1);
            this.Controls.Add(this.FinalScore_label1);
            this.Controls.Add(this.NewGame_label1);
            this.Controls.Add(this.GameOver_label1);
            this.Controls.Add(this.FlappyBird_pictureBox1);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlappyBird_pictureBox1;
        private System.Windows.Forms.Timer Flying_timer1;
        private System.Windows.Forms.Timer Fall_Down_timer1;
        private System.Windows.Forms.Timer Moving_Pipes_timer1;
        private System.Windows.Forms.Label GameOver_label1;
        private System.Windows.Forms.Label NewGame_label1;
        private System.Windows.Forms.Label FinalScore_label1;
        private System.Windows.Forms.Label Score_label1;
    }
}

