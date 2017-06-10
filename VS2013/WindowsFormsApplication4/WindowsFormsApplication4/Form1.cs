using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap b1, b2;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(b1, new Point(0, 0));
            e.Graphics.DrawImage(b2, new Point(0, 0));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b1 = new Bitmap(@"C:\Users\Florin\Desktop\Ma9Ed.png");
            b2 = new Bitmap(@"C:\Users\Florin\Desktop\TrZNl.png");
        }
    }
}
