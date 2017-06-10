using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Agenda' table. You can move, or remove it, as needed.
            this.agendaTableAdapter.Fill(this.database1DataSet.Agenda);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                agendaTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, textBox3.Text);
                agendaTableAdapter.Fill(database1DataSet.Agenda);
            }
            catch
            {
                MessageBox.Show("Date incorecte!");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            agendaTableAdapter.FillBy(database1DataSet.Agenda, textBox4.Text);
        }
    }
}
