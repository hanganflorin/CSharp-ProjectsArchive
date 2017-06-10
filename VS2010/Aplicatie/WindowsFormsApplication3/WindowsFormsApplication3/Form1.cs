using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        bool b = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            b = false;
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = b;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                b = false;
                Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text += "TROLL ";
            SendKeys.Send("TROLL");
            if ( label1.Font.Size < 50 )
                label1.Font = new Font(FontFamily.GenericSansSerif, label1.Font.Size + 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
