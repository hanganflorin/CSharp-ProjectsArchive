using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Baza_Date_Conectare
{
    public partial class Form3 : Form
    {
        string cale = null;
        public Form3()
        {
            InitializeComponent();
            ParolaTextbox.UseSystemPasswordChar = true;
            VerParolaTextbox.UseSystemPasswordChar = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (NumeTextbox.Text == "")
                MessageBox.Show("Introdu numele tau!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if ( PrenumeTextbox.Text == "" )
                MessageBox.Show("Introdu prenumele tau!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if ( UserTextbox.Text == "" )
                MessageBox.Show("Introdu numele tau de utilizator!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if ( ParolaTextbox.Text == "" )
                MessageBox.Show("Introdu o parola!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (VerParolaTextbox.Text == "" && checkBox1.Checked == false)
                MessageBox.Show("Introdu verificarea parolei!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (checkBox1.Checked == false && ParolaTextbox.Text != VerParolaTextbox.Text)
            {
                MessageBox.Show("Parola nu se potriveste cu verificarea ei.\nReintrodu parola!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ParolaTextbox.Clear();
                VerParolaTextbox.Clear();
                groupBox2.Focus();
                ParolaTextbox.Focus();
            }
            else
            {
                cale = Directory.GetCurrentDirectory();
                SqlConnection conn = new SqlConnection(@"server = .\sqlexpress;Database=Utilizatori.mdf;trusted_connection=True;AttachDbFileName = " + cale + @"\Utilizatori.mdf");
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM Users", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                bool exista = false;
                while (reader.Read())
                {
                    if (reader[3].ToString() == UserTextbox.Text)
                    {
                        exista = true;
                        break;
                    }
                }
                reader.Close();
                if (exista)
                {
                    MessageBox.Show("Un alt utilizator are acelasi Username.\nIncearca altul!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UserTextbox.Clear();
                    groupBox2.Focus();
                    UserTextbox.Focus();
                }
                else
                {
                    cmd = new SqlCommand(@"INSERT INTO Users (Nume, Prenume, UserName, Parola) VALUES ( '" + NumeTextbox.Text + "', '" + PrenumeTextbox.Text + "', '" + UserTextbox.Text + "', '" + ParolaTextbox.Text + "' )", conn);
                    cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Operatie reusita!");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                VerParolaTextbox.Enabled = false;
                label5.Enabled = false;
                ParolaTextbox.UseSystemPasswordChar = false;
                VerParolaTextbox.Text = "";
            }
            else
            {
                VerParolaTextbox.Enabled = true;
                label5.Enabled = true;
                ParolaTextbox.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Esti sigur ca vrei sa iesi?", "Atentie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }

        private void ParolaTextbox_TextChanged(object sender, EventArgs e)
        {
            if (ParolaTextbox.Text.Length >= 7)
            {
                pictureBox1.BackColor = Color.Yellow;
                if ( Ver())
                    pictureBox1.BackColor = Color.Green;
            }
            else
                pictureBox1.BackColor = Color.Red;
        }
        private bool Ver()
        {
            bool lit = false;
            bool cif = false;
            for (int i = 0; i < ParolaTextbox.Text.Length; ++i)
            {
                if (ParolaTextbox.Text[i] >= 48 && ParolaTextbox.Text[i] <= 57)
                {
                    cif = true;
                    if (lit)
                        return true;
                }
                if (ParolaTextbox.Text[i] >= 97 && ParolaTextbox.Text[i] <= 'z')
                {
                    lit = true;
                    if (cif)
                        return true;
                }
            }
            return false;
        }

        private void NumeTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 'a' || e.KeyChar > 'z')
                e.Handled = true;
        }
    }
}
