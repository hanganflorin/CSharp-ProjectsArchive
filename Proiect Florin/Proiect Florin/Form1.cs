using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Proiect_Florin
{
    public partial class Form1 : Form
    {
        Process[] p = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Actualizeaza();
        }

        private void Actualizeaza()
        {
            Lista.Items.Clear();
            button1.Enabled = false;
            p = Process.GetProcesses();
            for (int i = 0; i < p.Length - 1; ++i)
                Lista.Items.Add(p[i].ProcessName.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Actualizeaza();
            
        }

        private void Lista_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < p.Length - 1; ++i)
                    if (Lista.SelectedItem.ToString() == p[i].ProcessName)
                    {
                        p[i].Kill();
                        MessageBox.Show("Procesul s-a sters!");
                        Actualizeaza();
                        break;
                    }
            }
            catch (Exception x)
            {
                MessageBox.Show("Nu pot sterge procesul!");
            }
        }

        private void inchideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deschideUnNouProcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.ShowDialog();
        }

    }
}
