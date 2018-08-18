using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_Lab
{
    public partial class Form1 : Form
    {
        static int m = 10, n = 10;
        int[,] maze = new int[m, n];
        int heightRect = 20;
        int widthRect = 20;

        Graphics g;
        Rectangle[,] rectMaze;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rectMaze[i, j] = new Rectangle(i * heightRect, j * widthRect, heightRect, widthRect);
                    
                    g.DrawRectangle(Pens.Black, rectMaze[i, j]);
                    if(j % 2 == 0)
                    {
                        g.FillRectangle(Brushes.Black, rectMaze[i, j]);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.White, rectMaze[i, j]);
                    }
                    
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            maze.Initialize();
            this.BackColor = Color.Yellow;
            g = pictureBox1.CreateGraphics();
            rectMaze = new Rectangle[10, 10];
        }
    }
}
