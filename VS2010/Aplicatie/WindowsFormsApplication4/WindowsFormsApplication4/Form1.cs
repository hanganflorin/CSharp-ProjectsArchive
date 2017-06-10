using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        int mx_x = Screen.PrimaryScreen.Bounds.Width;
        int mx_y = Screen.PrimaryScreen.Bounds.Height;
        int d = 0; // 0 nord, 1 est, 2 sud, 3 vest
        Random r = new Random();
        List <Point> p2 = new List<Point>();
        Point[] p = new Point[3];
        Color c = new Color();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen pen = new Pen(c, 3);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            g.DrawLines(pen, p);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Space)
                Next();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p2.Add(new Point(mx_x / 2, mx_y / 2));
           // p2.Add(new Point(20, 20));
            //p = p2.ToArray();
            //Invalidate();
            
        }
        void Next()
        {
            int x = 0, y = 0;
            Point last = p2.Last();
            if (d == 0)
            {
                x = last.X;
                y = r.Next(1, last.Y-1);
            }
            if (d == 1)
            {
                x = r.Next(last.X + 1, mx_x - 1);
                y = last.Y;
            }
            if (d == 2)
            {
                x = last.X;
                y = r.Next(last.Y + 1, mx_y - 1);
            }
            if (d == 3)
            {
                x = r.Next(1, last.X - 1);
                y = last.Y;
            }
            p2.Add(new Point(x, y));
            p = p2.ToArray();
            d++;
            d %= 4;
            c = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            Invalidate();

        }
    }
}
