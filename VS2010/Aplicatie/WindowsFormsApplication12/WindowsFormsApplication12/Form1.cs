using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string time = null;
        int hh = 0, mm = 0, ss = 0;
        int h = 0, m = 0, s = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            h = f.Get_H();
            m = f.Get_M();
            s = f.Get_S();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            hh = DateTime.Now.Hour;
            mm = DateTime.Now.Minute;
            ss = DateTime.Now.Second;

            if (hh < 10) time = "0";
            time += hh + ":";
            if (mm < 10) time += "0";
            time += mm + ":";
            if (ss < 10) time += "0";
            time += ss;
            label1.Text = time;

            if (hh == h && mm == m && ss == s)
            {
                MessageBox.Show("Alarm");
            }

        }
    }
}
