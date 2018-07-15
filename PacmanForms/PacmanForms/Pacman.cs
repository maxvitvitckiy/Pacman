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
        Bitmap pacmanImg = new Bitmap(20,20);
        public Rectangle pacmanRectangle = new Rectangle(50, 50, 20, 20);
        Graphics g;

        int speed = 2;

        int[] vector; // X, Y: 1, 0, -1 -> куди рухається

        public Pacman()
        {
            pacmanImg = Properties.Resources.Pacman_pic;
            vector = new int[2] { 0, 0 };

            g.DrawImage(pacmanImg, pacmanRectangle.X, pacmanRectangle.Y);
        }

        public void Move()
        {
            pacmanRectangle.X += speed * vector[0];
            pacmanRectangle.Y += speed * vector[1];
            g.DrawImage(pacmanImg, pacmanRectangle.X, pacmanRectangle.Y);
        }
        
        public int GetX()
        {
            return pacmanRectangle.X;
        }
        public int GetY()
        {
            return pacmanRectangle.Y;
        }
        public int Vector{ get; set; }
    }
}
