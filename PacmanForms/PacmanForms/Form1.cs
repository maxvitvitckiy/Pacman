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


        public Form1()
        {
            InitializeComponent();
            t = new Timer();
            t.Interval = 10;
            pacman = new Pacman();
        }

        private bool checkBound()
        {
            if (pacman.GetX() < this.Size.Width - Properties.Resources.Pacman_pic.Width && pacman.GetY() < this.Size.Height - Properties.Resources.Pacman_pic.Height)
                return true;

            return false;
        }

        private void t_Tick(object sender, EventArgs e)
        {
            if (checkBound())
                pacman.Move();
            else
                pacman.Vector = 0;

        }

        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
                pacman.Vector = {0, 1};
            else if(e.KeyCode == Keys.Down)
        }
    }
}
