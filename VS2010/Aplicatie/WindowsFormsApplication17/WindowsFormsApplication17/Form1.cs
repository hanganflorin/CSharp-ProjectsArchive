using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Medicamente' table. You can move, or remove it, as needed.
            this.medicamenteTableAdapter.Fill(this.database1DataSet.Medicamente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //modificam pretul 
            medicamenteTableAdapter.UpdateQuery(int.Parse(textBox2.Text), int.Parse(textBox1.Text));
            this.medicamenteTableAdapter.Fill(this.database1DataSet.Medicamente);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //afisam tot
            this.medicamenteTableAdapter.Fill(this.database1DataSet.Medicamente);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //afisam medicamente necompensate
            medicamenteTableAdapter.FillBy(this.database1DataSet.Medicamente);
        }
    }
}
