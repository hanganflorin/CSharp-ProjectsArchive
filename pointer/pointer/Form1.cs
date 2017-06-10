using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pointer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n = 100;
        private void button1_Click(object sender, EventArgs e)
        {
            n--;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = n.ToString();
        }
    }
}
