﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //label1.Text = e.Delta.ToString();
            //label1.Text = SystemInformation.
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           // label1.Text = e.Delta.ToString();
        }
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            label1.Text = e.Delta.ToString();
        }
    }
}
