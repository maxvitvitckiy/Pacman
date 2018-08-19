using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman_Test
{
    class Maze
    {
        int width = 25, height = 25;
        List<Rectangle> walls = new List<Rectangle>();
        List<Rectangle> path = new List<Rectangle>();

        int[,] mazeInt = {

               { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
               { 1,1,1,1,0,0,1,1,0,0,1,0,0,1,1,0,0,1,1,0,1 },
               { 1,1,1,0,0,0,1,1,0,0,1,0,0,1,1,0,0,0,0,0,1 },
               { 1,0,1,1,0,0,1,1,0,0,1,0,0,1,1,0,0,1,1,0,1 },
               { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
               { 1,0,1,1,0,0,0,0,1,1,1,1,1,0,0,0,0,1,1,0,1 },
               { 1,0,0,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0,0,0,1 },
               { 1,0,0,0,0,0,1,1,1,0,1,0,1,1,1,0,0,0,0,0,1 },
               { 1,1,1,1,0,0,1,0,0,0,0,0,0,0,1,0,0,1,1,1,1 },
               { 1,1,1,1,0,0,0,0,1,1,0,1,1,0,0,0,0,1,1,1,1 },
               { 1,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,1 },
               { 1,1,1,1,0,1,0,0,1,1,1,1,1,0,0,1,0,1,1,1,1 },
               { 1,1,1,1,0,1,0,0,0,0,0,0,0,0,0,1,0,1,1,1,1 },
               { 1,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,1 },
               { 1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1 },
               { 1,0,1,1,0,0,1,1,1,0,1,0,1,1,1,0,0,1,1,0,1 },
               { 1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,1 },
               { 1,1,0,0,0,1,0,0,0,1,1,1,0,0,0,1,0,0,0,1,1 },
               { 1,0,0,1,1,1,1,1,0,0,1,0,0,1,1,1,1,1,0,0,1 },
               { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
               { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 }
        };
        
        public Maze()
        {
            for (int i = 0; i < mazeInt.GetLength(0); i++)
            {
                for (int j = 0; j < mazeInt.GetLength(1); j++)
                {
                    if (mazeInt[i, j] == 1)
                        walls.Add(new Rectangle(j * width, i * height, width, height));                    
                    else
                        path.Add(new Rectangle(j * width, i * height, width, height));
                }
            }

        }

        public Size GetSize()
        {
            return new Size(mazeInt.GetLength(0) * width + 17, mazeInt.GetLength(1) * height + 40);
        }

        public bool CheckBorderds(int x, int y)
        {
            if (mazeInt[x / width, y / height] == 1) return false;
            
            return true;
        }

        public List<Rectangle> getRectanglesWall()
        {
            return walls;
        }

        public List<Rectangle> getRectanglePath()
        {
            return path;
        }

        public int this[int i, int j]
        {
            get { return mazeInt[i, j]; }
        }


    }
}