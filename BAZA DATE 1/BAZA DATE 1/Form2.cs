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
    public partial class Form2 : Form
    {
        int nr = 0;
        string titlu = null;
        bool salvat = true;
        public Form2(int v)
        {
            nr = v;
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"server = .\sqlexpress;Database=Users.mdf;trusted_connection=True;AttachDbFileName = C:\BAZA DATE 1\BAZA DATE 1\bin\Debug\Users.mdf");
            conn.Open();
            cmd = new SqlCommand(@"SELECT * FROM Utilizatori WHERE IdUtilizator = " + nr, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            textBox1.Text = reader[5].ToString();
            titlu = reader[1] + " " + reader[2] + " " + '"' + reader[3] + '"';
            this.Text = titlu;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == reader[5].ToString())
            {
                salvat = true;
                this.Text = titlu;
            }
            else
            {
                salvat = false;
                this.Text = "* " + titlu;
            }
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cmd = new SqlCommand(@"UPDATE Utilizatori SET Text = '" + textBox1.Text + "' WHERE IDUtilizator = " + nr, conn );
            cmd = new SqlCommand(@"UPDATE Utilizatori SET Text = 'Florin' WHERE IDUtilizator = 1", conn);
            //cmd = new SqlCommand(@"SELECT * FROM Utilizatori WHERE IdUtilizator = " + nr, conn);
            salvat = true;
            this.Text = titlu;
        }

        private void deconectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salvat == false)
            {
                DialogResult dg = MessageBox.Show("Textul nu a fost salvat.\nSalvati?", "Atentie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( dg == DialogResult.Yes )
                    cmd = new SqlCommand(@"UPDATE Utilizatori SET Text = " + textBox1.Text + "WHERE IDUtilizator = " + nr, conn);
            }
            reader.Close();
            conn.Close();
        }
    }
}
