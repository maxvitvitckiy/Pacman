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
        Timer t;
        Pacman pacman;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;

            pacman = new Pacman();

            g = this.CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawImage(pacman.GetPacmanImg(), pacman.GetRect());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pacman.SetVectorX(1);
            }
            pacman.Move();
            g.DrawImage(pacman.GetPacmanImg(), pacman.GetRect());

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
