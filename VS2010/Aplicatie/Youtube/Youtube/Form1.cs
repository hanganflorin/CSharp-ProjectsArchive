using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Youtube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SearchOption option;
        string[] s;
        private void Form1_Load(object sender, EventArgs e)
        {
            option = SearchOption.TopDirectoryOnly;
            folderBrowserDialog1.ShowNewFolderButton = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;
                textBox1.Clear();
                s = Directory.GetFiles(label1.Text, "*", option);
                foreach( string a in s)
                {
                    textBox1.Text += a.ToString() + Environment.NewLine;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                option = SearchOption.AllDirectories;
            else
                option = SearchOption.TopDirectoryOnly;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

    }
}
