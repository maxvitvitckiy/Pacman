using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanForms
{
    public partial class Form1 : Form
    {
        Pacman pacman;
        Graphics g;
        Maze m;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;

            pacman = new Pacman();
            m = new Maze();
            
            timer1.Interval = 10;
            timer1.Enabled = true;
            g = this.CreateGraphics();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CheckBorders();
            pacman.Move();
            Refresh();
            g.DrawImage(pacman.GetPacmanImg(), pacman.GetRect());

        }

        private void DrawMaze()
        {
            for (int i = 0; i < 5; i++)
                g.DrawRectangle(Pens.Blue, m[i]);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.DrawMaze();

            g.DrawImage(pacman.GetPacmanImg(), pacman.GetRect());
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if ( == Keys.Right)
            //{
            //    pacman.SetVectorX(1);
            //    pacman.SetVectorY(0);
            //}
            //else if (e.KeyChar. == Keys.Left)
            //{
            //    pacman.SetVectorX(-1);
            //    pacman.SetVectorY(0);
            //}
            //else if (e.KeyCode == Keys.Down)
            //{
            //    pacman.SetVectorX(0);
            //    pacman.SetVectorY(-1);
            //}

            //else if (e.KeyCode == Keys.Up)
            //{
            //    pacman.SetVectorX(0);
            //    pacman.SetVectorY(1);
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pacman.SetVectorX(1);
                pacman.SetVectorY(0);
            }
            else if (e.KeyCode == Keys.Left)
            {
                pacman.SetVectorX(-1);
                pacman.SetVectorY(0);
            }
            else if (e.KeyCode == Keys.Down)
            {
                pacman.SetVectorX(0);
                pacman.SetVectorY(-1);
            }

            else if (e.KeyCode == Keys.Up)
            {
                pacman.SetVectorX(0);
                pacman.SetVectorY(1);
            }
            //pacman.Move();
            //Refresh();
            //g.DrawImage(pacman.GetPacmanImg(), pacman.GetRect());
        }

        private void CheckBorders()
        {
            if ((pacman.GetRect().X >= this.ClientSize.Width - pacman.GetPacmanImg().Width && pacman.GetVectorX() > 0)|| (pacman.GetRect().X <= 0 && pacman.GetVectorX() < 0)) pacman.SetVectorX(0);
            if ((pacman.GetRect().Y >= this.ClientSize.Height - pacman.GetPacmanImg().Height && pacman.GetVectorY() < 0) || (pacman.GetRect().Y <= 0 && pacman.GetVectorY() > 0)) pacman.SetVectorY(0);


            for (int i = 0; i < 10; i++)
            {
                if ((pacman.GetRect().X == this.ClientRectangle.X + m[i].X && pacman.GetVectorX() > 0) || (pacman.GetRect().X <= 0 && pacman.GetVectorX() < 0))
                    pacman.SetVectorX(0);
                if ((pacman.GetRect().Y == this.ClientRectangle.Y + m[i].Y && pacman.GetVectorY() < 0)|| (pacman.GetRect().Y <= 0 && pacman.GetVectorY() > 0))
                    pacman.SetVectorY(0);

            }
        }

        //private bool checkBound()
        //{
        //    if (pacman.GetX() < this.Size.Width - Properties.Resources.Pacman_pic.Width && pacman.GetY() < this.Size.Height - Properties.Resources.Pacman_pic.Height)
        //        return true;

        //    return false;
        //}

        //private void t_Tick(object sender, EventArgs e)
        //{
        //    if (checkBound())
        //        pacman.Move();
        //    else
        //        pacman.SetVector(new int[] { 0, 1 });

        //}

        //private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //if(e.KeyCode == Keys.Up) pacman.SetVector(new int[]{ 0, 1 });
        //    pacman.SetVector(new int[] { 0,-1 });
        //    pacman.Move();
        //}
    }
}
