using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanForms
{
    class Pacman
    {
        Bitmap pacman = new Bitmap(20,20);
        Rectangle pacmanRectangle = new Rectangle(50, 50, 20, 20);
        Graphics g;

        int speed = 2;

        int[] vector; // X, Y: 1, 0, -1 -> куди рухається

        public Pacman()
        {
            pacman = Properties.Resources.Pacman_pic;
            vector = new int[2] { 0, 0 };

        }

        public void Move()
        {
            pacmanRectangle.X += speed * vector[0];
            pacmanRectangle.Y += speed * vector[1];
            g.DrawImage(pacman, pacmanRectangle.X, pacmanRectangle.Y);
        }
        

    }
}
