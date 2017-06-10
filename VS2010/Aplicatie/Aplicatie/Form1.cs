using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicatie
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
        int dim = 100;
        Random r = new Random();
        List<Rectangle> rectangle = new List<Rectangle>();
        List<SolidBrush> sb = new List<SolidBrush>();


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
            if (e.KeyCode == Keys.Space)
                Next();
            if (e.KeyCode == Keys.Up)
            {
                dim++;
                Update();
            }
            if (e.KeyCode == Keys.Down && dim > 1 )
            {
                dim--;
                Update();
            }
            if (e.KeyCode == Keys.Enter)
            {
                Culori();
            }
            if (e.KeyCode == Keys.Delete )
            {
                rectangle.Clear();
                sb.Clear();
                Invalidate();
            }
            if (e.KeyCode == Keys.Back && rectangle.Count != 0 )
            {
                rectangle.RemoveAt(rectangle.Count-1);
                sb.RemoveAt(sb.Count-1);
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            for (int i = 0; i < rectangle.Count; ++i)
                g.FillRectangle(sb[i], rectangle[i]);
            
        }
        void Next()
        {
            rectangle.Add(new Rectangle(r.Next(mx_x-dim), r.Next(mx_y-dim), dim, dim));
            sb.Add(new SolidBrush(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255))));
            Invalidate();
        }
        void Update()
        {
            for (int i = 0; i < rectangle.Count; ++i)
                rectangle[i] = new Rectangle(rectangle[i].X, rectangle[i].Y, dim, dim);
            Invalidate();
        }
        void Culori()
        {
            for ( int i = 0; i < sb.Count; ++i )
                sb[i] = new SolidBrush(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)));
            Invalidate();
        }
    }
}
