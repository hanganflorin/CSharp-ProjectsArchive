using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCarti.Carti' table. You can move, or remove it, as needed.
            this.cartiTableAdapter.Fill(this.dataSetCarti.Carti);

        }

        private void button_Adauga_Click(object sender, EventArgs e)
        {
            try
            {
                int An_Ap = Convert.ToInt32(textBox_AnAp.Text);
                int Nr_Pag = Convert.ToInt32(textBox_NrPag.Text);
                int Pret = Convert.ToInt32(textBox_Pret.Text);
                int Nota = Convert.ToInt32(numericUpDown_Nota.Value);
                cartiTableAdapter.InsertQuery(textBox_Titlu.Text, textBox_Autor.Text, An_Ap, Nr_Pag, Pret, Nota);
                this.cartiTableAdapter.Fill(this.dataSetCarti.Carti);
            }
            catch
            {
                MessageBox.Show("Date incorecte!", "Eroare");
            }
        }

        private void button_Sorteaza_Click(object sender, EventArgs e)
        {
            if (radioButton_Autor.Checked)
                cartiTableAdapter.FillByAuthor(this.dataSetCarti.Carti);
            if (radioButton_Nota.Checked)
                cartiTableAdapter.FillByRate(this.dataSetCarti.Carti);
            if (radioButton2_NrPag.Checked)
                cartiTableAdapter.FillByPages(this.dataSetCarti.Carti);
        }

        private void button_Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
