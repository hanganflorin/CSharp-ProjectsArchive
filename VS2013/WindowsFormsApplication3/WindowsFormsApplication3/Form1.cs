using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                trackBar1.Minimum = Convert.ToInt32(textBox1.Text);
                trackBar1.Maximum = Convert.ToInt32(textBox2.Text);
                trackBar1.Minimum *= 10;
                trackBar1.Maximum *= 10;
            }
            catch { }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }
    }
}
