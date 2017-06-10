using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Limba_Romana
{
    public partial class Form2 : Form
    {
        int c = 0;
        int g = 0;
        int t = 0;
        bool reset = false;
        public bool Val
        {
            get { return reset; }
        }
        public Form2(int _c, int _g, int _t)
        {
            c = _c;
            g = _g;
            t = _t;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = c.ToString();
            label5.Text = g.ToString();
            label6.Text = t.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Sigur vrei sa resetezi statisticile?", "Atentie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                reset = true;
                label4.Text = "0";
                label5.Text = "0";
                label6.Text = "0";
            }
        }
    }
}
