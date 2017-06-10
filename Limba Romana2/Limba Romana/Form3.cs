using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Limba_Romana
{
    public partial class Form3 : Form
    {
        public Form3(bool[] _p, int x)
        {
            p = _p;
            v = x;
            InitializeComponent();
        }
        public bool[] Item
        {
            get { return p; }
        }
        public int Val
        {
            get { return v; }
        }
        bool[] p = new bool[31];
        int v = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 31; ++i)
                p[i] = true;
            checkBox1.Checked = p[1];
            checkBox2.Checked = p[2];
            checkBox3.Checked = p[3];
            checkBox4.Checked = p[4];
            checkBox5.Checked = p[5];
            checkBox6.Checked = p[6];
            checkBox7.Checked = p[7];
            checkBox8.Checked = p[8];
            checkBox9.Checked = p[9];
            checkBox10.Checked = p[10];
            checkBox11.Checked = p[11];
            checkBox12.Checked = p[12];
            checkBox13.Checked = p[13];
            checkBox14.Checked = p[14];
            checkBox15.Checked = p[15];
            checkBox16.Checked = p[16];
            checkBox17.Checked = p[17];
            checkBox18.Checked = p[18];
            checkBox19.Checked = p[19];
            checkBox20.Checked = p[20];
            checkBox21.Checked = p[21];
            checkBox22.Checked = p[22];
            checkBox23.Checked = p[23];
            checkBox24.Checked = p[24];
            checkBox25.Checked = p[25];
            checkBox26.Checked = p[26];
            checkBox27.Checked = p[27];
            checkBox28.Checked = p[28];
            checkBox29.Checked = p[29];
            checkBox30.Checked = p[30];
            switch (v)
            {
                case 0: radioButton1.Checked = true; break;
                case 1: radioButton1.Checked = true; break;
                case 2: radioButton1.Checked = true; break;
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = checkBox31.Checked;
            checkBox2.Checked = checkBox31.Checked;
            checkBox3.Checked = checkBox31.Checked;
            checkBox4.Checked = checkBox31.Checked;
            checkBox5.Checked = checkBox31.Checked;
            checkBox6.Checked = checkBox31.Checked;
            checkBox7.Checked = checkBox31.Checked;
            checkBox8.Checked = checkBox31.Checked;
            checkBox9.Checked = checkBox31.Checked;
            checkBox10.Checked = checkBox31.Checked;
            checkBox11.Checked = checkBox31.Checked;
            checkBox12.Checked = checkBox31.Checked;
            checkBox13.Checked = checkBox31.Checked;
            checkBox14.Checked = checkBox31.Checked;
            checkBox15.Checked = checkBox31.Checked;
            checkBox16.Checked = checkBox31.Checked;
            checkBox17.Checked = checkBox31.Checked;
            checkBox18.Checked = checkBox31.Checked;
            checkBox19.Checked = checkBox31.Checked;
            checkBox20.Checked = checkBox31.Checked;
            checkBox21.Checked = checkBox31.Checked;
            checkBox22.Checked = checkBox31.Checked;
            checkBox23.Checked = checkBox31.Checked;
            checkBox24.Checked = checkBox31.Checked;
            checkBox25.Checked = checkBox31.Checked;
            checkBox26.Checked = checkBox31.Checked;
            checkBox27.Checked = checkBox31.Checked;
            checkBox28.Checked = checkBox31.Checked;
            checkBox29.Checked = checkBox31.Checked;
            checkBox30.Checked = checkBox31.Checked;
            for (int i = 0; i < 31; ++i)
                p[i] = checkBox31.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            p[1] = checkBox1.Checked;
            p[2] = checkBox2.Checked;
            p[3] = checkBox3.Checked;
            p[4] = checkBox4.Checked;
            p[5] = checkBox5.Checked;
            p[6] = checkBox6.Checked;
            p[7] = checkBox7.Checked;
            p[8] = checkBox8.Checked;
            p[9] = checkBox9.Checked;
            p[10] = checkBox10.Checked;
            p[11] = checkBox11.Checked;
            p[12] = checkBox12.Checked;
            p[13] = checkBox13.Checked;
            p[14] = checkBox14.Checked;
            p[15] = checkBox15.Checked;
            p[16] = checkBox16.Checked;
            p[17] = checkBox17.Checked;
            p[18] = checkBox18.Checked;
            p[19] = checkBox19.Checked;
            p[20] = checkBox20.Checked;
            p[21] = checkBox21.Checked;
            p[22] = checkBox22.Checked;
            p[23] = checkBox23.Checked;
            p[24] = checkBox24.Checked;
            p[25] = checkBox25.Checked;
            p[26] = checkBox26.Checked;
            p[27] = checkBox27.Checked;
            p[28] = checkBox28.Checked;
            p[29] = checkBox29.Checked;
            p[30] = checkBox30.Checked;
            /*
            if (checkBox1.Checked == false &&
                checkBox2.Checked == false &&
                checkBox3.Checked == false &&
                checkBox4.Checked == false &&
                checkBox5.Checked == false &&
                checkBox6.Checked == false &&
                checkBox7.Checked == false &&
                checkBox8.Checked == false &&
                checkBox9.Checked == false &&
                checkBox10.Checked == false &&
                checkBox11.Checked == false &&
                checkBox12.Checked == false &&
                checkBox13.Checked == false &&
                checkBox14.Checked == false &&
                checkBox15.Checked == false &&
                checkBox16.Checked == false &&
                checkBox17.Checked == false &&
                checkBox18.Checked == false &&
                checkBox19.Checked == false &&
                checkBox20.Checked == false &&
                checkBox21.Checked == false &&
                checkBox22.Checked == false &&
                checkBox23.Checked == false &&
                checkBox24.Checked == false &&
                checkBox25.Checked == false &&
                checkBox26.Checked == false &&
                checkBox27.Checked == false &&
                checkBox28.Checked == false &&
                checkBox29.Checked == false &&
                checkBox30.Checked == false
                )
                checkBox31.Checked = false;

            if (checkBox1.Checked == true &&
                checkBox2.Checked == true &&
                checkBox3.Checked == true &&
                checkBox4.Checked == true &&
                checkBox5.Checked == true &&
                checkBox6.Checked == true &&
                checkBox7.Checked == true &&
                checkBox8.Checked == true &&
                checkBox9.Checked == true &&
                checkBox10.Checked == true &&
                checkBox11.Checked == true &&
                checkBox12.Checked == true &&
                checkBox13.Checked == true &&
                checkBox14.Checked == true &&
                checkBox15.Checked == true &&
                checkBox16.Checked == true &&
                checkBox17.Checked == true &&
                checkBox18.Checked == true &&
                checkBox19.Checked == true &&
                checkBox20.Checked == true &&
                checkBox21.Checked == true &&
                checkBox22.Checked == true &&
                checkBox23.Checked == true &&
                checkBox24.Checked == true &&
                checkBox25.Checked == true &&
                checkBox26.Checked == true &&
                checkBox27.Checked == true &&
                checkBox28.Checked == true &&
                checkBox29.Checked == true &&
                checkBox30.Checked == true
                )
                checkBox31.Checked = false;
             */

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBox1.Checked == false &&
                checkBox2.Checked == false &&
                checkBox3.Checked == false &&
                checkBox4.Checked == false &&
                checkBox5.Checked == false &&
                checkBox6.Checked == false &&
                checkBox7.Checked == false &&
                checkBox8.Checked == false &&
                checkBox9.Checked == false &&
                checkBox10.Checked == false &&
                checkBox11.Checked == false &&
                checkBox12.Checked == false &&
                checkBox13.Checked == false &&
                checkBox14.Checked == false &&
                checkBox15.Checked == false &&
                checkBox16.Checked == false &&
                checkBox17.Checked == false &&
                checkBox18.Checked == false &&
                checkBox19.Checked == false &&
                checkBox20.Checked == false &&
                checkBox21.Checked == false &&
                checkBox22.Checked == false &&
                checkBox23.Checked == false &&
                checkBox24.Checked == false &&
                checkBox25.Checked == false &&
                checkBox26.Checked == false &&
                checkBox27.Checked == false &&
                checkBox28.Checked == false &&
                checkBox29.Checked == false &&
                checkBox30.Checked == false
                )
            {
                MessageBox.Show("Trebuie sa alegi cel putin o poezie");
                e.Cancel = true;
            }
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                v = 0;
            if (radioButton2.Checked)
                v = 1;
            if (radioButton3.Checked)
                v = 2;
        }
    }
}
