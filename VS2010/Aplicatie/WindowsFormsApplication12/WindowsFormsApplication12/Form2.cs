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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int Get_H()
        {
            return Convert.ToInt32(numericUpDown1.Value);
        }
        public int Get_M()
        {
            return Convert.ToInt32(numericUpDown2.Value);
        }
        public int Get_S()
        {
            return Convert.ToInt32(numericUpDown3.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
