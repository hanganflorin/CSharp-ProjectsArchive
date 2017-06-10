using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace contex_menu_strip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] files = null;
        int nr = 0;
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = true;
            timer1.Start();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startToolStripMenuItem.Enabled = true;
            stopToolStripMenuItem.Enabled = false;
            timer1.Stop();
        }

        private void inchideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            files = Directory.GetFiles("C:\\Users\\Elev\\Desktop\\Folder nou");
            pictureBox1.Image = Image.FromFile(files[0]);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            nr++;
            if (nr == files.Length)
                nr = 0;
            pictureBox1.Image = Image.FromFile(files[nr]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nr++;
            if (nr == files.Length)
                nr = 0;
            pictureBox1.Image = Image.FromFile(files[nr]);
        }

        private void urmatorulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nr++;
            if (nr == files.Length)
                nr = 0;
            pictureBox1.Image = Image.FromFile(files[nr]);
        }

        private void anteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nr--;
            if (nr == -1 )
                nr = files.Length-1;
            pictureBox1.Image = Image.FromFile(files[nr]);
        }

        private void micaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            micaToolStripMenuItem.Checked = true;
            medieToolStripMenuItem.Checked = false;
            mareToolStripMenuItem.Checked = false;
            foarteMareToolStripMenuItem.Checked = false;
            timer1.Interval = 6500;
        }

        private void medieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            micaToolStripMenuItem.Checked = false;
            medieToolStripMenuItem.Checked = true;
            mareToolStripMenuItem.Checked = false;
            foarteMareToolStripMenuItem.Checked = false;
            timer1.Interval = 5000;
        }

        private void mareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            micaToolStripMenuItem.Checked = false;
            medieToolStripMenuItem.Checked = false;
            mareToolStripMenuItem.Checked = true;
            foarteMareToolStripMenuItem.Checked = false;
            timer1.Interval = 4000;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (e.KeyCode == Keys.Space)
            {
                if (startToolStripMenuItem.Enabled == true)
                {
                    startToolStripMenuItem.Enabled = false;
                    stopToolStripMenuItem.Enabled = true;
                    timer1.Start();
                }
                else
                {
                    startToolStripMenuItem.Enabled = true;
                    stopToolStripMenuItem.Enabled = false;
                    timer1.Stop();
                }
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Right)
            {
                nr++;
                if (nr == files.Length)
                    nr = 0;
                pictureBox1.Image = Image.FromFile(files[nr]);
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Left)
            {
                nr--;
                if (nr == -1)
                    nr = files.Length - 1;
                pictureBox1.Image = Image.FromFile(files[nr]);
            }
        }

        private void foarteMareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            micaToolStripMenuItem.Checked = false;
            medieToolStripMenuItem.Checked = false;
            mareToolStripMenuItem.Checked = false;
            foarteMareToolStripMenuItem.Checked = true;
            timer1.Interval = 100;
        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoToolStripMenuItem.Checked = true;
            centruToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
            strechToolStripMenuItem.Checked = false;
            zoomToolStripMenuItem.Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void centruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoToolStripMenuItem.Checked = false;
            centruToolStripMenuItem.Checked = true;
            normalToolStripMenuItem.Checked = false;
            strechToolStripMenuItem.Checked = false;
            zoomToolStripMenuItem.Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoToolStripMenuItem.Checked = false;
            centruToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = true;
            strechToolStripMenuItem.Checked = false;
            zoomToolStripMenuItem.Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void strechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoToolStripMenuItem.Checked = false;
            centruToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
            strechToolStripMenuItem.Checked = true;
            zoomToolStripMenuItem.Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoToolStripMenuItem.Checked = false;
            centruToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
            strechToolStripMenuItem.Checked = false;
            zoomToolStripMenuItem.Checked = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
