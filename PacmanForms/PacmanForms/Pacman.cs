using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PacmanForms
{
    class Pacman
    {
        private Bitmap pacmanImg = Properties.Resources.Pacman_pic;

        private Rectangle pacmanRect;



        int vectorX;
        int vectorY;

        int speed = 1;
        public Pacman()
        {
            ChangeSize(20, 20);
            pacmanRect = new Rectangle(200, 200, pacmanImg.Width, pacmanImg.Height);

            vectorX = 0;
            vectorY = 0;
        }

        public int GetVectorX()
        {
            return vectorX;
        }

        public int GetVectorY()
        {
            return vectorY;
        }

        public void Move()
        {
            pacmanRect.X += speed * vectorX;
            pacmanRect.Y += -1 * speed * vectorY;
            
        }

        public Rectangle GetRect()
        {
            return pacmanRect;
        }

        public Bitmap GetPacmanImg()
        {
            return pacmanImg;
        }

        public void SetPacmanImg(Bitmap newImg)
        {
            pacmanImg = newImg;
            ChangeSize(20, 20);
        }



        public void SetVectorX(int a)
        {
            vectorX = a;
        }

        public void SetVectorY(int a)
        {
            vectorY = a;
        }

        private void ChangeSize(int x, int y)
        {
            pacmanImg = new Bitmap(pacmanImg, x, y);
        }

//        Bitmap pacmanImg = new Bitmap(20,20);
//        public Rectangle pacmanRectangle = new Rectangle(50, 50, 20, 20);
//        Graphics g;

//        int speed = 2;

//        int[] vector; // X, Y: 1, 0, -1 -> куди рухається

//        public Pacman()
//        {
//            pacmanImg = Properties.Resources.Pacman_pic;
//            vector = new int[2] { 0, 0 };

//            g.DrawImage(pacmanImg, pacmanRectangle.X, pacmanRectangle.Y);
//        }

//       

//        public int GetX()
//        {
//            return pacmanRectangle.X;
//        }
//        public int GetY()
//        {
//            return pacmanRectangle.Y;
//        }

//        public void SetVector(int[] value)
//        {
//            vector[0] = value[0];
//            vector[1] = value[1];
//        }
    }
}
