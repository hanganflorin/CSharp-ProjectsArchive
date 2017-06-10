using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lines
{
    public partial class Form1 : Form
    {
        
        List<Point> p2 = new List<Point>();
        Point[] p = new Point[3];
        bool da = false;
        public Form1()
        {
            InitializeComponent();
        }
       // Graphics g;
        int dim = 2;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pn = new Pen(Color.Red, dim);
            pn.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pn.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLines(pn, p);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (e.KeyCode == Keys.Right)
                dim++;
            if (e.KeyCode == Keys.Left)
                dim--;
        }
        int nr = 2;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!da)
            {
                p[1].X = Cursor.Position.X;
                p[1].Y = Cursor.Position.Y;
                p[0].X = p[1].X;
                p[0].Y = p[1].Y;
                da = true;
                timer1.Start();
            }
            else
            {
                p2 = p.ToList();
                p2.Add(new Point(p[nr].X, p[nr].Y));
                p = p2.ToArray();
                nr++;
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            p[nr].X = Cursor.Position.X;
            p[nr].Y = Cursor.Position.Y;
            int x1 = p[nr].X, y1 = p[nr].Y, x2 = p[nr-1].X, y2 = p[nr-1].Y;
            //Rectangle rc = new Rectangle(p[nr-1].X, p[nr-1].Y, p[nr].X, p[nr].Y ); 
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }
    }
}
