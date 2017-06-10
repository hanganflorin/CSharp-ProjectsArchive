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
    public partial class Form2 : Form
    {
        string cale = null;
        int nr = 0;
        string titlu = null;
        string text_salvat = null;
        bool salvat = true;
        public Form2(int v)
        {
            nr = v;
            InitializeComponent();
        }
        SqlDataReader reader = null;
        SqlDataReader rd = null;
        SqlConnection conn = null;
        SqlCommand cmd = null;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == text_salvat)
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
        private void Form2_Load(object sender, EventArgs e)
        {
            cale = Directory.GetCurrentDirectory();
            conn = new SqlConnection(@"server = .\sqlexpress;Database=Utilizatori.mdf;trusted_connection=True;AttachDbFileName = " + cale + @"\Utilizatori.mdf");
            conn.Open();
            cmd = new SqlCommand(@"SELECT * FROM Users WHERE Id = " + nr, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            textBox1.Text = reader[5].ToString();
            text_salvat = reader[5].ToString();
            titlu = reader[1] + " " + reader[2] + " " + '"' + reader[3] + '"';
            this.Text = titlu;
            reader.Close();
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            cmd = new SqlCommand(@"UPDATE Users SET Text = '" + textBox1.Text + "' WHERE ID = " + nr, conn);
            text_salvat = textBox1.Text;
            rd = cmd.ExecuteReader(); // FOARTE IMPORTANT
            salvat = true;
            this.Text = titlu;
            rd.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salvat == true)
            {
                DialogResult d = MessageBox.Show("Vrei sa iesi?", "Atentie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.No)
                    e.Cancel = true;
            }
            else
            {
                DialogResult dg = MessageBox.Show("Textul nu a fost salvat.\nSalvati?", "Atentie", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                    Save();
                if (dg == DialogResult.Cancel)
                    e.Cancel = true;
            }
            reader.Close();
        }

        private void deconectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
                Save();
        }
    }
}
