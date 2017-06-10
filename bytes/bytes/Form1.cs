using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[] b;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(Get(b, b.Length) + System.Environment.NewLine);
        }
        public string Get(byte[] b, int n)
        {
            string s = null;
            for (int i = 0; i < n; ++i)
                s += " " + b[i].ToString();
            return s;
        }
        public void Rand(byte[] b, int n)
        {
            Random r = new Random();
            for (int i = 0; i < n; ++i)
            {
                if (r.Next(2) == 1)
                    b[i] = 1;
                else
                    b[i] = 0;
            }
            r.NextBytes(b);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            b = new byte[1024];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rand(b, b.Length);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nr = 0;
            Bitmap bitmap = new Bitmap(1366, 768);
            for (int i = 0; i < bitmap.Width; ++i)
                for (int j = 0; j < bitmap.Height; ++j)
                    bitmap.SetPixel(i, j, Color.FromArgb(b[nr++], b[nr++], b[nr++]));
            pictureBox1.Image = bitmap;
        }
    }
}
