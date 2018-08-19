using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman_Test
{
    class Pacman
    {
        public Bitmap Pacman_Pic { get; set; }
        private byte k;
        public int Speed { get; }
        public int VectorX { get; set; }
        public int VectorY { get; set; }

        public Pacman()
        {
            k = 0;
            Speed = 1;
            VectorX = 0;
            VectorY = 0;
        }

        public void IncreaseK()
        {
            k++;
        }

        private void SetPacmanImg(Bitmap newImg)
        {
            Pacman_Pic = newImg;
        }

        public void setVectors(int vectorX, int vectorY)
        {
            VectorX = vectorX;
            VectorY = vectorY;
        }

        public void setAnimation()
        {
            if (k % 4 == 0)
            {
                SetPacmanImg(new Bitmap(Properties.Resources.sprite_0, 22, 22));
            }
            else if (k % 4 == 1)
            {
                SetPacmanImg(new Bitmap(Properties.Resources.sprite_1, 22, 22));
            }
            else if (k % 4 == 2)
            {
                SetPacmanImg(new Bitmap(Properties.Resources.sprite_2, 22, 22));
            }
            else if (k % 4 == 3)
            {
                SetPacmanImg(new Bitmap(Properties.Resources.sprite_3, 22, 22));
            }
            setRotate();
        }

        public void setRotate()
        {
            if (VectorY == 1)
                Pacman_Pic.RotateFlip(RotateFlipType.Rotate270FlipNone);
            if (VectorY == -1)
                Pacman_Pic.RotateFlip(RotateFlipType.Rotate90FlipNone);
            if (VectorX == -1)
                Pacman_Pic.RotateFlip(RotateFlipType.Rotate180FlipY);
        }
    }
}
