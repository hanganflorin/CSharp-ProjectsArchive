using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Rectangle r1 = new Rectangle(10, 10, 1, 1);
        Rectangle r2 = new Rectangle(11, 10, 1, 1);
        Rectangle r3 = new Rectangle(12, 10, 1, 1);
        Rectangle r4 = new Rectangle(11, 12, 1, 1);
        SolidBrush s1 = new SolidBrush(Color.Black);
        SolidBrush s2 = new SolidBrush(Color.Black);
        SolidBrush s3 = new SolidBrush(Color.Black);
        SolidBrush s4 = new SolidBrush(Color.Black);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            g = e.Graphics;
            g.FillRectangle(s1, r1);
            g.FillRectangle(s2, r2);
            g.FillRectangle(s3, r3);
            g.FillRectangle(s4, r4);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                if (s1.Color == Color.Black)
                    s1.Color = Color.Red;
                else
                    s1.Color = Color.Black;
            }
            if (e.KeyCode == Keys.D2)
            {
                if (s2.Color == Color.Black)
                    s2.Color = Color.Green;
                else
                    s2.Color = Color.Black;
            }
            if (e.KeyCode == Keys.D3)
            {
                if (s3.Color == Color.Black)
                    s3.Color = Color.Blue;
                else
                    s3.Color = Color.Black;
            }
            if (e.KeyCode == Keys.Q)
            {
                if (s4.Color.R == 0)
                    s4.Color = Color.FromArgb(255, s4.Color.G, s4.Color.B);
                else
                    s4.Color = Color.FromArgb(0, s4.Color.G, s4.Color.B);
            }
            if (e.KeyCode == Keys.W)
            {
                if (s4.Color.G == 0)
                    s4.Color = Color.FromArgb(s4.Color.R, 255, s4.Color.B);
                else
                    s4.Color = Color.FromArgb(s4.Color.R, 0, s4.Color.B);
            }
            if (e.KeyCode == Keys.E)
            {
                if (s4.Color.B == 0)
                    s4.Color = Color.FromArgb(s4.Color.R, s4.Color.G, 255);
                else
                    s4.Color = Color.FromArgb(s4.Color.R, s4.Color.G, 0);
            }
            Invalidate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
