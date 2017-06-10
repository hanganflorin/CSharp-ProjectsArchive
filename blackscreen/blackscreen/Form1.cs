using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace blackscreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        List<Rectangle> r1 = new List<Rectangle>();
        List<SolidBrush> sb = new List<SolidBrush>();
        int dim = 30;
        int nr = 0;
        int diag = 1;
        int x;
        int y;
        private void Form1_Load(object sender, EventArgs e)
        {
            r1.Add(new Rectangle(0, 0, dim, dim));
            sb.Add(new SolidBrush(Color.Empty));
            x = -1 * dim;
            y = -1 * dim;

        }
        Graphics g;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (e.KeyCode == Keys.Back)
            {
                r1.Clear();
                sb.Clear();
                diag = 0;
                x = -dim;
                y = -dim;
                //r1.Add(new Rectangle(0, 0, 50, 50));
                Invalidate();
                nr = 0;
            }
            if (e.KeyCode == Keys.Space)
            {
                Rezolvare();
                Valideaza();
            }
            if (e.KeyCode == Keys.A)
            {
                Rezolvare();
                Valideaza();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (timer1.Enabled)
                    timer1.Enabled = false;
                else
                    timer1.Enabled = true;
            }
            if (e.KeyCode == Keys.Subtract)
            {
                if ( dim != 1 )
                    dim--;
            }
            if (e.KeyCode == Keys.Add)
                dim++;
            if (e.KeyCode == Keys.B)
            {
                for (int i = 0; i < sb.Count; ++i)
                    sb[i] = new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
                Valideaza();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            for (int i = 0; i < r1.Count; ++i)
                g.FillRectangle(sb[i], r1[i]);
        }
        private void Rezolvare()
        {
            if (diag == 1)
            {
                x += dim;
                y += dim;
                r1.Add(new Rectangle(x, y, dim, dim));
                sb.Add(new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))));
                if (y >= this.Size.Height - dim) //
                    diag = 2;
                if (x >= this.Size.Width - dim) //
                    diag = 4;
            }
            else if (diag == 2)
            {
                y -= dim;
                x += dim;
                r1.Add(new Rectangle(x, y, dim, dim));
                sb.Add(new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))));
                if (x >= this.Size.Width - dim)//
                    diag = 3;
                if (y <= 0)
                    diag = 1;
            }
            else if (diag == 3)
            {
                x -= dim;
                y -= dim;
                r1.Add(new Rectangle(x, y, dim, dim));
                sb.Add(new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))));
                if (y <= 0)
                    diag = 4;
                if (x <= 0)
                    diag = 2;
            }
            else if ( diag == 4 )
            {
                x -= dim;
                y += dim;
                r1.Add(new Rectangle(x, y, dim, dim));
                sb.Add(new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))));
                if (y >= this.Size.Height - dim)//
                    diag = 3;
                if (x <= 0)
                    diag = 1;
            }
        }
        bool da = false;
        bool f = false;
        bool da2 = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Rezolvare();
            if (da2)
            {
                if (da)
                {
                    if (f)
                    {
                        dim++;
                        f = false;
                    }
                    else
                        f = true;
                    if (dim == 30)
                        da = false;
                }
                else
                {
                    if (f)
                    {
                        dim--;
                        f = false;
                    }
                    else
                        f = true;
                    if (dim == 0)
                        da = true;
                }
            }
            Valideaza();
            
        }

        private void Valideaza()
        {
            try
            {
                Invalidate(r1[r1.Count - 1]);
            }
            catch
            {
                Invalidate();
            }
        }
    }
}
