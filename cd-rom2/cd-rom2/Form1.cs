using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);
        
        bool x = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                timer1.Start();
                this.button1.Text = "Stop";
                x = false;
            }
            else
            {
                timer1.Stop();
                this.button1.Text = "Start";
                x = true;
            }
            
        }
        bool da = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (da == true)
            {
                mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
                da = false;
            }
            else
            {
                mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
                da = true;
            }
            
        }
    }
}
