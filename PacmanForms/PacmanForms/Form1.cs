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

        public Form1()
        {
            InitializeComponent();
            t = new Timer();
            t.Interval = 1;
        }

        private void t_Tick(object sender, EventArgs e)
        {

        }
    }
}
