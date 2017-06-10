using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proiect_Florin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Introdu un nou proces!");
            else
            {
                try
                {
                    System.Diagnostics.Process.Start(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Procesul pe care l-ai deschis nu este valid!!");
                }
            }
            
        }
    }
}
