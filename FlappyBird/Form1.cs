using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        bool Fly_Boolean = false;
        int Target_Y_Location = 800;

        Random rnd = new Random();
        int Pipe_Timer_Counter = 39;

        bool GameOver = false;
        int Score = 0;
        int Pipe_Passed = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Fly_Boolean)
            {
                FlappyBird_pictureBox1.Image = Properties.Resources.FlappyBird;
                Fly_Boolean = false;
            }
            else
            {

                FlappyBird_pictureBox1.Image = Properties.Resources.FlappyBird2;
                Fly_Boolean = true;
            }
        }

        private void Fall_Down_timer1_Tick(object sender, EventArgs e)
        {
            if (FlappyBird_pictureBox1.Top != Target_Y_Location)
            {
                if (FlappyBird_pictureBox1.Top < Target_Y_Location)
                {
                    FlappyBird_pictureBox1.Top = FlappyBird_pictureBox1.Top + 10;
                }
                else
                {
                    FlappyBird_pictureBox1.Top = FlappyBird_pictureBox1.Top - 10;
                }
            }
            else
            {
                if (Target_Y_Location == 800)
                {
                    Target_Y_Location = 200;
                }
                else
                {
                    if (Target_Y_Location != 800)
                    {
                        Target_Y_Location = 800;
                    }
                    else
                    {
                        NewGame_label1.Visible = true;
                        GameOver_label1.Visible = true;

                        FinalScore_label1.Text="YOUR SCORE:"+ Score.ToString();
                        FinalScore_label1.Visible = true;
                        FinalScore_label1.BringToFront();

                        NewGame_label1.BringToFront();
                        GameOver_label1.BringToFront();
                        Flying_timer1.Enabled = false;
                        Fall_Down_timer1.Enabled = false;
                        Moving_Pipes_timer1.Enabled = false;
                    }
                }
            }

        }

        private void FlappyBird_pictureBox1_Click(object sender, EventArgs e)
        {
            if (!GameOver)
            {
                Target_Y_Location = FlappyBird_pictureBox1.Top - 80;
            }

        }

        public void Create_Upper_n_Lower_Pipes()
        {
            var p = new PictureBox();
            p.BackColor = Color.Green;
            p.BorderStyle = BorderStyle.None;
            p.Size = new Size(170, 100);
            int random_Y = rnd.Next(5, 27);
            int random_Y_multiplie_10 = random_Y * 10;
            p.Location = new Point(1000, random_Y_multiplie_10);
            p.Image = Properties.Resources.PipeHead;
            p.Visible = true;
            this.Controls.Add(p);


            var p2 = new PictureBox();
            p2.BackColor = Color.Green;
            p2.BorderStyle = BorderStyle.None;
            p2.Size = new Size(150, random_Y_multiplie_10);
            p2.Location = new Point(1010, 0);
            p2.BackgroundImage = Properties.Resources.PipeBody;
            p2.BackgroundImageLayout = ImageLayout.Tile;
            p2.Visible = true;
            this.Controls.Add(p2);

            var p3 = new PictureBox();
            p3.BackColor = Color.Green;
            p3.BorderStyle = BorderStyle.None;
            p3.Size = new Size(170, 100);
            p3.Location = new Point(1000, random_Y_multiplie_10 + 340);
            p3.Image = Properties.Resources.PipeHead;
            p3.Visible = true;
            this.Controls.Add(p3);


            var p4 = new PictureBox();
            p4.BackColor = Color.Green;
            p4.BorderStyle = BorderStyle.None;
            p4.Size = new Size(150, 800 - random_Y_multiplie_10 + 340);
            p4.Location = new Point(1010, random_Y_multiplie_10 + 340 + 100);
            p4.BackgroundImage = Properties.Resources.PipeBody;
            p4.BackgroundImageLayout = ImageLayout.Tile;
            p4.Visible = true;
            this.Controls.Add(p4);



            p.BringToFront();
            p2.BringToFront();
            p3.BringToFront();
            p4.BringToFront();

        }



        private void Moving_Pipes_timer1_Tick(object sender, EventArgs e)
        {
            Pipe_Timer_Counter++;
            if (Pipe_Timer_Counter == 40)
            {
                Create_Upper_n_Lower_Pipes();
                Pipe_Timer_Counter = 0;
            }
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pipes = c as PictureBox;
                    if (pipes.BackColor == Color.Green)
                    {
                        pipes.Left = pipes.Left - 10;

                        if (FlappyBird_pictureBox1.Bounds.IntersectsWith(pipes.Bounds))
                        {
                            Check_Pipe_Crush(pipes);
                        }

                        if (pipes.Left < -170)
                        {
                            pipes.Dispose();
                        }

                        if(pipes.Left == -50 && pipes.Visible)
                        {
                            Pipe_Passed++;
                            if(Pipe_Passed== 4)
                            {
                                Score = Score + 10;
                                Score_label1.Text = Score.ToString();
                                Pipe_Passed = 0;
                            }
                        }
                    }
                }
            }
        }

        public void Check_Pipe_Crush(PictureBox pipes)
        {
            if (pipes.BackColor == Color.Green && pipes.Visible)
            {
                if (pipes.Width == 170)
                {
                    if ((pipes.Top == FlappyBird_pictureBox1.Top - 90 && pipes.Left < 240 && pipes.Left > -10) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 80 && pipes.Left < 250 && pipes.Left > -10) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 70 && pipes.Left < 260 && pipes.Left > -20) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 60 && pipes.Left < 270 && pipes.Left > -40) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 50 && pipes.Left < 270 && pipes.Left > -50) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 40 && pipes.Left < 270 && pipes.Left > -50) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 30 && pipes.Left < 280 && pipes.Left > -50) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 20 && pipes.Left < 290 && pipes.Left > -50) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 10 && pipes.Left < 290 && pipes.Left > -50) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top && pipes.Left < 290 && pipes.Left > -50) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 10 && pipes.Left < 290 && pipes.Left > -50) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 20 && pipes.Left < 290 && pipes.Left > -50) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 30 && pipes.Left < 290 && pipes.Left > -50) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 40 && pipes.Left < 290 && pipes.Left > -50) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 50 && pipes.Left < 290 && pipes.Left > -50) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 60 && pipes.Left < 290 && pipes.Left > -50) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 70 && pipes.Left < 290 && pipes.Left > -40) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 80 && pipes.Left < 280 && pipes.Left > -30) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 90 && pipes.Left < 280 && pipes.Left > -30) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 100 && pipes.Left < 270 && pipes.Left > -20) ||
                        (pipes.Top == FlappyBird_pictureBox1.Top - 110 && pipes.Left < 220 && pipes.Left > -0))
                    {

                    }

                }
                else
                {
                    GAME_OVER();
                }
            }
        }




        public void GAME_OVER()
        {
            Target_Y_Location = 800;
            Moving_Pipes_timer1.Enabled = false;
            NewGame_label1.Visible = true;
            GameOver_label1.Visible = true;

            FinalScore_label1.Text = "YOUR SCORE: " + Score.ToString();
            FinalScore_label1.Visible = true;
            FinalScore_label1.BringToFront();

            NewGame_label1.BringToFront();
            GameOver_label1.BringToFront();
            Flying_timer1.Enabled = false;
            Fall_Down_timer1.Enabled = false;
        }
        private void NewGame_label1_MouseHover(object sender, EventArgs e)
        {
            NewGame_label1.BackColor = Color.Lime;
        }

        private void NewGame_label1_MouseLeave(object sender, EventArgs e)
        {
            NewGame_label1.BackColor = Color.Lime;
        }

        private void NewGame_label1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox pipes = c as PictureBox;
                    if (pipes.BackColor == Color.Lime)
                    {
                        pipes.Visible = false;
                    }
                }
            }
            Target_Y_Location = 800;
            Pipe_Timer_Counter = 39;
            GameOver = false;
            FlappyBird_pictureBox1.Location = new Point(120, 280);
            GameOver_label1.Visible = false;
            NewGame_label1.Visible = false;
            Score_label1.Text = "0";
            FinalScore_label1.Text ="YOUR SCORE:0";
            FinalScore_label1.Visible = false;
            Score = 0;
            Pipe_Passed = 0;
            Flying_timer1.Enabled = true;
            Fall_Down_timer1.Enabled = true;
            Moving_Pipes_timer1.Enabled = true;
        }
    }
}