using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Process[] p = null;
        string nume = "";
        int n = 5;
        int x = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            p = Process.GetProcesses();
            for (int i = 0; i < p.Length; ++i)
            {
                if (p[i].ProcessName == nume)
                {
                    timer2.Start();
                    x = i;
                    timer1.Stop();
                    break;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = Process.GetProcesses();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            n--;
            if (n == 0)
            {
                this.SetTopLevel(true);
                MessageBox.Show("Salut");
                n = 5;
                timer2.Stop();
            }
        }
    }
}
