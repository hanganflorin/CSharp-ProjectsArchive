using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace KeyL
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int i);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread tr = new Thread(Start);
            tr.Start();
        }
        private void Start()
        {
            int KeyState = 0;
            while ( true )
            {
                Thread.Sleep(10);
                for ( int i = 0; i < 255; ++i )
                {
                    KeyState = GetAsyncKeyState(i);
                    if ( KeyState == 1 || KeyState == -32767 )
                    {
                        UpdateUI( Convert.ToString((Keys)i) + " " +  i.ToString() );
                    }
                }
            }
        }
        private void UpdateUI(string s)
        {
            Func<int> del = delegate()
            {
                listBox1.Items.Add(s);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                return 0;
            };
            Invoke(del);
        }
    }
}
