using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Bitmap b;
        int W, H;
        private void Form1_Load(object sender, EventArgs e)
        {
            W = Screen.PrimaryScreen.Bounds.Width;
            H = Screen.PrimaryScreen.Bounds.Height;
            b = new Bitmap(W, H);
            g = Graphics.FromImage(b);
            g.CopyFromScreen(0, 0, 0, 0, new Size(W, H));
            //b.
        }
    }
}
