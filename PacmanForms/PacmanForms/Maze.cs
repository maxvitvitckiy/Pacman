using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PacmanForms
{
    class Maze
    {
        Rectangle[] walls;


        public Maze()
        {
            walls = new Rectangle[5];
            walls[0] = new Rectangle(0, 10, 20, 70);
            walls[1] = new Rectangle(0, 10, 20, 70);
            walls[2] = new Rectangle(0, 10, 70, 20);
            walls[3] = new Rectangle(0, 10, 70, 20);
            walls[4] = new Rectangle(0, 10, 20, 20);

        }

        public void drawMaze(Rectangle client)
        {
            
        }
    }
}
