using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int mx_x = Screen.PrimaryScreen.Bounds.Width;
        int mx_y = Screen.PrimaryScreen.Bounds.Height;
        Graphics g;
        Random r = new Random();
        List<Rectangle> rect = new List<Rectangle>();
        List<SolidBrush> sb = new List<SolidBrush>();
        int dim = 20;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            for (int i = 0; i < rect.Count; ++i)
                g.FillRectangle(sb[i], rect[i]);
        }
        void RResize()
        {
            rect.Clear();
            sb.Clear();
            int x = 0;
            int y = 0;
            while (y < mx_y)
            {
                x = 0;
                while (x < mx_x)
                {
                    rect.Add(new Rectangle(x, y, dim, dim));
                    sb.Add(new SolidBrush(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255))));
                    x+=dim;
                }
                y+=dim;
            }
            Invalidate();
        }
        void Colors()
        {
            for (int i = 0; i < sb.Count; ++i)
                sb[i].Color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            Invalidate();
        }
        void Awesome()
        {
            int t = sb.Count;
            for (int i = 0; i < sb.Count; i += 3 )
            {
                sb[i].Color = Color.FromArgb( 255, 0, 0);
                sb[i+1].Color = Color.FromArgb( 0, 255, 0);
                sb[i+2].Color = Color.FromArgb( 20, 0, 255);
            }
            Invalidate();
        }
        void Awesome2()
        {
            int t = sb.Count;
            for (int i = 0; i < sb.Count; i++)
            {
                sb[i].Color = Color.FromArgb(0, (i * 64) / t, 0);
            }
            Invalidate();
        }
        void Awesome3()
        {
            int t = sb.Count;
            for (int i = 0; i < sb.Count; i++)
            {
                sb[i].Color = Color.FromArgb(((i * 255) / t) % 256, ((i * 510) / t) % 256, ((i * 765) / t) % 256);
            }
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                dim++;
                RResize();
            }
            if (e.KeyCode == Keys.Down && dim > 1 )
            {
                dim--;
                RResize();
            }
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Space)
                Colors();
            switch (e.KeyCode)
            {
                case Keys.X: Awesome(); break;
                case Keys.C: Awesome2(); break;
                case Keys.V: Awesome3(); break;
            }
        }
    }
}
