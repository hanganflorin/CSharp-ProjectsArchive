using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BAZA_DATE_1
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
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand(@"SELECT * FROM Utilizatori", conn);
            reader = cmd.ExecuteReader();
            if (UserTextbox.Text == "")
                MessageBox.Show("Introdu utilizator!");
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
                    cmd = new SqlCommand(@"SELECT * FROM Utilizatori WHERE IDUtilizator = " + nr, conn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader[4].ToString() == ParolaTextbox.Text)
                    {
                        MessageBox.Show("Autentificare cu succes!!");
                        this.Hide();
                        Form2 f = new Form2(nr);
                        f.ShowDialog();
                        UserTextbox.Text = "";
                        ParolaTextbox.Text = "";
                        this.Show();
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
                conn = new SqlConnection(@"server = .\sqlexpress;Database=Users.mdf;trusted_connection=True;AttachDbFileName = C:\BAZA DATE 1\BAZA DATE 1\bin\Debug\Users.mdf");
                conn.Open();
                cmd = new SqlCommand(@"SELECT * FROM Utilizatori", conn);
                reader = cmd.ExecuteReader();
                reader.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
    }
}
