using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace memorie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<byte[]> d;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            d = new List<byte[]>();
            byte s = new byte();
            s.
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d.Add(new byte[1048576]);
            label1.Text = d.Count.ToString();
        }
    }
}
