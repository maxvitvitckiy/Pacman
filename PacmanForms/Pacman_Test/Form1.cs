using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_Test
{
    public partial class Form1 : Form
    {
        Bitmap m, m2;
        Graphics g;
        Maze maze = new Maze();
        Pacman pacman;


        public void Move()
        {
            CheckBorders();
            pictureBox2.Location = new Point(pictureBox2.Location.X + pacman.Speed * pacman.VectorX, pictureBox2.Location.Y + pacman.Speed * pacman.VectorY * -1);
        }

        public Form1()
        {
            InitializeComponent();
            this.Size = maze.GetSize();
            pacman = new Pacman();

            pacman.Pacman_Pic = new Bitmap(Properties.Resources.sprite_0, 22, 22);
            pictureBox2.Image = pacman.Pacman_Pic;

            m = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = m;
            pictureBox1.BackColor = Color.Transparent;


            timer1.Interval = 100;
            timer1.Enabled = true;
            Draw();
            timer2.Interval = 20;
            timer2.Enabled = true;
        }

        private void CheckBorders()
        {
            if (pictureBox2.Top == 0 && pacman.VectorY == 1) pacman.setVectors(0,0);
            if (pictureBox2.Left == 0 && pacman.VectorX == -1) pacman.setVectors(0, 0);
            if (pictureBox2.Bottom == this.ClientSize.Height && pacman.VectorY == -1) pacman.setVectors(0, 0);
            if (pictureBox2.Right == this.ClientSize.Width && pacman.VectorX == 1) pacman.setVectors(0, 0);


            
            foreach (Rectangle w in maze.getRectanglesWall())
            {
                //if (((w.X == pictureBox2.Right && pacman.VectorX > 0)
                //    || (w.Right == pictureBox2.Left && pacman.VectorX < 0))
                //    && ((pictureBox2.Top >= w.Top && pictureBox2.Top <= w.Bottom)
                //    || (w.Y <= pictureBox2.Bottom && w.Y >= pictureBox2.Top)))
                //        pacman.setVectors(0, 0);
                Point a = new Point((w.Right - w.Left) / 2 + w.Left,(w.Bottom - w.Top) / 2 + w.Top);
                Point b = new Point((pictureBox2.Right - pictureBox2.Left) / 2 + pictureBox2.Left, (pictureBox2.Bottom - pictureBox2.Top) / 2 + pictureBox2.Top);
                double minDistance = (pictureBox2.Width + w.Width) / 2;
                double distanceX = a.Y - b.Y;
                double distanceY = a.X - b.X;
                if ((distanceX <= minDistance && distanceX >= minDistance * -1)|| (distanceY < minDistance  && distanceY >= minDistance * -1))
                {
                    if ((distanceX < 0 && pacman.VectorX == -1) || (distanceX > 0 && pacman.VectorX == 1 )|| (distanceY < 0 && pacman.VectorY == -1) || (distanceY > 0 && pacman.VectorY == 1))
                    {
                        pacman.setVectors(0, 0);
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                    }
                }
            }
        }

        private void Draw() {

            using (g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.Transparent);

                foreach (Rectangle r in maze.getRectanglesWall())
                {
                    g.DrawRectangle(Pens.Black, r);
                    g.FillRectangle(Brushes.DarkGreen, r);
                }
                foreach(Rectangle r in maze.getRectanglePath())
                {
                    g.DrawRectangle(Pens.Black, r);
                    g.FillRectangle(Brushes.Aqua, r);
                }
            }
            pictureBox1.Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Move();
            pictureBox2.Refresh();
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            if (e.KeyCode == Keys.Right) pacman.setVectors(1, 0);
            else if (e.KeyCode == Keys.Left) pacman.setVectors(-1, 0);
            else if (e.KeyCode == Keys.Down) pacman.setVectors(0, -1);
            else if (e.KeyCode == Keys.Up) pacman.setVectors(0, 1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pacman.IncreaseK();
            pacman.setAnimation();
            pictureBox2.Image = pacman.Pacman_Pic;
        }
    }
}
