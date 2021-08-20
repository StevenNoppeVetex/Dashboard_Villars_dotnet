using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_Villars_dotnet
{
    public partial class frmDoek : Form
    {
        frmMain frmMain;                                        // nodig om aan de tekstvakken in het hoofdvenster te kunnen
        public frmDoek(frmMain form)
        {
            InitializeComponent();
            
            this.frmMain = form;                                // nodig om aan de tekstvakken in het hoofdvenster te kunnen
        }

        // venster is ingeladen
        private void frmDoek_Load(object sender, EventArgs e)
        {
            // Zet de cursor focus op het tekstvak "Ingave Passage", zodat operator onmiddelijk al kan inscannen
            txtIngaveDoek.Focus();
        }

        // Gebruiker heeft op de knop "OK" gedrukt
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Creëer een nieuwe rij in de datagridview "doek 1" in het hoofd venster en kopieer het tekstvak "ingave doek 1" naar de eerste kolom
            // Rijen worden eerst geteld en een nieuwe rij wordt toegevoegd
            string[] row = new string[] { (frmMain.dgvDoek1.RowCount + 1).ToString(), txtIngaveDoek.Text, "0" };
            frmMain.dgvDoek1.Rows.Add(row);

            // sluit het venster
            this.Close();
        }

        // Gebruiker heeft op de knop "annuleren" gedrukt
        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            // sluit het venster
            this.Close();
        }

        // Gebruiker heeft op de knop "wis" gedrukt
        private void btnWis_Click(object sender, EventArgs e)
        {
            // wis het gehele tekstvak 
            txtIngaveDoek.Text = "";
        }

        // Gebruiker heeft op de knop "1" gedrukt
        private void btn1_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "1" toe aan het tekstvak "Ingave Doek"
            txtIngaveDoek.Text += "1";
        }

        // Gebruiker heeft op de knop "2" gedrukt
        private void btn2_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "2" toe aan het tekstvak "Ingave Doek"
            txtIngaveDoek.Text += "2";
        }

        // Gebruiker heeft op de knop "3" gedrukt
        private void btn3_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "3" toe aan het tekstvak "Ingave Doek"
            txtIngaveDoek.Text += "3";
        }

        // Gebruiker heeft op de knop "4" gedrukt
        private void btn4_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "4" toe aan het tekstvak "Ingave Doek"
            txtIngaveDoek.Text += "4";
        }

        // Gebruiker heeft op de knop "5" gedrukt
        private void btn5_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "5" toe aan het tekstvak "Ingave Doek"
            txtIngaveDoek.Text += "5";
        }

        // Gebruiker heeft op de knop "6" gedrukt
        private void btn6_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "6" toe aan het tekstvak "Ingave Doek"
            txtIngaveDoek.Text += "6";
        }

        // Gebruiker heeft op de knop "7" gedrukt
        private void btn7_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "7" toe aan het tekstvak "Ingave Doek"
            txtIngaveDoek.Text += "7";
        }

        // Gebruiker heeft op de knop "8" gedrukt
        private void btn8_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "8" toe aan het tekstvak "Ingave Doek"
            txtIngaveDoek.Text += "8";
        }

        // Gebruiker heeft op de knop "9" gedrukt
        private void btn9_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "9" toe aan het tekstvak "Ingave Doek"
            txtIngaveDoek.Text += "9";
        }

        // Gebruiker heeft op de knop "0" gedrukt
        private void btn0_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "0" toe aan het tekstvak "Ingave Doek"
            txtIngaveDoek.Text += "0";
        }

        // Gebruiker heeft op de knop "C" gedrukt
        private void btnC_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "C" toe aan het tekstvak "Ingave Doek"
            txtIngaveDoek.Text += "C";
        }

        // Gebruiker heeft op de knop "E" gedrukt
        private void btnE_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "E" toe aan het tekstvak "Ingave Doek"
            txtIngaveDoek.Text += "E";
        }

        // Gebruiker heeft op de knop "F" gedrukt
        private void btnF_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "F" toe aan het tekstvak "Ingave Doek"
            txtIngaveDoek.Text += "F";
        }

        // Gebruiker heeft op de knop "-" gedrukt
        private void btnMinTeken_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "-" toe aan het tekstvak "Ingave Doek"
            txtIngaveDoek.Text += "-";
        }
    }
}
