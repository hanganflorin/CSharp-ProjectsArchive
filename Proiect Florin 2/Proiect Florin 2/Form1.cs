using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect_Florin_2
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int x, y, n = 0, t = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (button1.Text == "Start!")
            {
                timer1.Start();
                button2.Visible = false;
            }
            x = r.Next(button1.Size.Width / 2, this.Size.Width - button1.Size.Width);
            y = r.Next(button1.Size.Height / 2, this.Size.Height - button1.Size.Height);
            button1.Location = new Point(x, y);
            n++;
            button1.Text = n.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t--;
            label2.Text = t.ToString();
            if (t == 0)
            {
                timer1.Stop();
                MessageBox.Show("Scorul tau: " + n.ToString());
                Reset();
            }
        }
        void Reset()
        {
            button2.Visible = true;
            button1.Text = "Start!";
            button1.Location = new Point(this.Width / 2, this.Height / 2);
            n = 0;
            t = 5;
            label2.Text = "5";
        }
    }
}
