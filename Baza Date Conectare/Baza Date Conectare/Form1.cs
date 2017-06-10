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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int nr = 1; // pozitia utilizatorului
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        string cale = null;
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand(@"SELECT * FROM Users", conn);
            reader = cmd.ExecuteReader();
            if (UserTextbox.Text == "")
                MessageBox.Show("Introdu numele tau de utilizator!");
            else if (ParolaTextbox.Text == "")
                MessageBox.Show("Indrodu parola");
            else
            {
                bool am_gasit = false;
                nr = 1;
                while (reader.Read())
                {
                    if (reader[3].ToString() == UserTextbox.Text)
                    {
                        am_gasit = true;
                        break;
                    }
                    nr++;
                }
                if (am_gasit == false)
                {
                    MessageBox.Show("UserName inexistent!");
                    groupBox1.Focus();
                    UserTextbox.Focus();
                    UserTextbox.SelectAll();
                }
                else
                {
                    reader.Close();
                    cmd = new SqlCommand(@"SELECT * FROM Users WHERE ID = " + nr, conn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader[4].ToString() == ParolaTextbox.Text)
                    {
                        MessageBox.Show("Autentificare cu succes!!");
                        this.Hide();
                        Form2 f = new Form2(nr);
                        f.ShowDialog();
                        f.Close();
                        groupBox1.Focus();
                        UserTextbox.Focus();
                        UserTextbox.SelectAll();
                        ParolaTextbox.Text = "";
                        this.Show();
                        UserTextbox.SelectAll();
                    }
                    else
                        MessageBox.Show("Parola gresita!!");
                }
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ParolaTextbox.UseSystemPasswordChar = true;
            try
            {
                cale = Directory.GetCurrentDirectory();
                conn = new SqlConnection(@"server = .\sqlexpress;Database=Utilizatori.mdf;trusted_connection=True;AttachDbFileName = " + cale + @"\Utilizatori.mdf");
                conn.Open();
                cmd = new SqlCommand(@"SELECT * FROM Users", conn);
                reader = cmd.ExecuteReader();
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare" + ex.ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                ParolaTextbox.UseSystemPasswordChar = false;
            else
                ParolaTextbox.UseSystemPasswordChar = true;
            groupBox1.Focus();
            ParolaTextbox.Focus();
        }

        private void creareContNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
            f.Close();
        }
    }
}
