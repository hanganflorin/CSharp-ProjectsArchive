using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Limba_Romana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form3 f = null;
        int x = 0;
        bool[] p = new bool[31];
        int v = 0;
        int st1 = 0;
        int st2 = 0;
        int st3 = 0;
        Random rnd = new Random();
        StreamReader sr = null;
        List<string> s = null;
        List<string> titlu = null;
        List<string> _S = null;
        List<string> _Titlu = null;
        string[] nr = null;
        string a;
        string title = null;
        int strofe = 0;
        int vers = 0;
        public string[] poezii = new string[31];
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 31; ++i)
                p[i] = true;
            f = new Form3(p, x);
            s = new List<string>();
            titlu = new List<string>();
            _S = new List<string>();
            _Titlu = new List<string>();
            sr = new StreamReader(Directory.GetCurrentDirectory() + @"\Nu_modifica_aceasta_fila.txt");
            for (int k = 0; k < 30; ++k)
            {
                a = sr.ReadLine();
                nr = a.Split(' ');
                vers = int.Parse(nr[0]);
                strofe = int.Parse(nr[1]);

                title = sr.ReadLine();
                sr.ReadLine();
                AddTitlu();

                for (int i = 0; i < strofe; ++i)
                {
                    string str = null;
                    for (int j = 0; j < vers+1; ++j)
                    {
                        str += sr.ReadLine();
                        str += '\n';
                    }
                    s.Add(str);
                }
                sr.ReadLine();
                sr.ReadLine();
            }
            v = rnd.Next(s.Count);
            label1.Text = s[v];
            for (int i = 1; i < 31; ++i)
                poezii[i] = comboBox1.Items[i-1].ToString();
            for (int i = 0; i < s.Count; ++i)
                _S.Add(s[i]);
            for (int i = 0; i < titlu.Count; ++i)
                _Titlu.Add(titlu[i]);
        }
        private void AddTitlu()
        {
            title = title.ToUpper();
            for (int i = 0; i < strofe; ++i)
                titlu.Add(title);
            comboBox1.Items.Add(title);
        }
        private void Debug()
        {
            for (int i = 0; i < s.Count; ++i)
            {
                label1.Text += s[i];
                label2.Text += titlu[i] + '\n';
            }
            
        }

        private void button1_Click(object sender, EventArgs e) //
        {
            v = rnd.Next(_S.Count);
            if (x == 0)
                label1.Text = _S[v];
            else if (x == 1)
            {
                string[] vrs = _S[v].Split('\n');
                int nr = vrs.Length - 1;
                while (vrs[nr] == "")
                    nr--;
                label1.Text = vrs[rnd.Next(nr + 1)];
            }
            else
            {
                int b = rnd.Next(2);
                if (b == 0)
                    label1.Text = _S[v];
                else
                {
                    string[] vrs = _S[v].Split('\n');
                    int nr = vrs.Length - 1;
                    while (vrs[nr] == "")
                        nr--;
                    label1.Text = vrs[rnd.Next(nr + 1)];
                }
            }
            st3++;
        }

        private void button2_Click(object sender, EventArgs e) //
        {
            if (comboBox1.SelectedIndex == -1 && checkBox1.Checked == false )
                MessageBox.Show("Alege un titlu!");
            else
            {
                if (checkBox1.Checked == false)
                {
                    if (comboBox1.SelectedItem.ToString() == _Titlu[v])
                    {
                        MessageBox.Show("Corect");
                        st1++;
                    }
                    else
                    {
                        MessageBox.Show("Gresit\nRaspuns corect: " + _Titlu[v]);
                        st2++;
                    }
                }
                else
                {
                    if (textBox1.Text.ToUpper() == _Titlu[v])
                    {
                        MessageBox.Show("Corect");
                        st1++;
                    }
                    else
                    {
                        MessageBox.Show("Gresit\nRaspuns corect: " + _Titlu[v]);
                        st2++;
                    }
                    textBox1.SelectAll();
                    textBox1.Focus();
                }
                button1.PerformClick();
                st3--;
            }
        }

        private void veziStatisticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(st1, st2, st3);
            f.ShowDialog();
            if (f.Val == true)
            {
                st1 = 0;
                st2 = 0;
                st3 = 0;
            }
        }

        private void alegePoeziileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
            p = f.Item;
            x = f.Val;
            _S.Clear();
            _Titlu.Clear();
            int cnt = 0;
            comboBox1.Items.Clear();
            for (int i = 0; i < titlu.Count; ++i)
            {
                for ( int j = 1; j < 31; ++j )
                {
                    if (poezii[j] == titlu[i])
                    {
                        cnt = j;
                        break;
                    }
                }
                if ( p[cnt] == true )
                {
                    if ( !comboBox1.Items.Contains( titlu[i] ) )
                        comboBox1.Items.Add(titlu[i]);
                    _Titlu.Add(titlu[i]);
                        _S.Add(s[i]);

                }
            }
            button1.PerformClick();
            st3--;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                label3.Text = "Alege titlul";
                comboBox1.Visible = true;
                textBox1.Visible = false;
            }
            else
            {
                label3.Text = "Scrie titlul";
                comboBox1.Visible = false;
                textBox1.Visible = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button2.PerformClick();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
