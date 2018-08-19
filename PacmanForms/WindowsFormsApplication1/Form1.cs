using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {


        Bitmap m, m2;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            m = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = m;
         
           // m2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
           // pictureBox2.BackgroundImage = m2;
            pictureBox2.BackColor = Color.Coral;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.Transparent);
                g.DrawImage(Properties.Resources.ss, 0, 0, 20, 20);
            }
            Refresh();
        }
    }
}
