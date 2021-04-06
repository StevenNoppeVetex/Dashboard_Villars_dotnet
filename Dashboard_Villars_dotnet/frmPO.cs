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
    public partial class frmPO : Form
    {
        frmMain frmMain;                                        // nodig om aan de tekstvakken in het hoofdvenster te kunnen

        public frmPO(frmMain form)
        {
            InitializeComponent();

            this.frmMain = form;                                // nodig om aan de tekstvakken in het hoofdvenster te kunnen
        }

        // Gebruiker heeft op de knop "PO" gedrukt
        private void btnPO_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "PO" toe aan het tekstvak "Ingave PO"
            txtIngavePO.Text += "PO";
        }

        // Gebruiker heeft op de knop "1" gedrukt
        private void btn1_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "1" toe aan het tekstvak "Ingave PO"
            txtIngavePO.Text += "1";
        }

        // Gebruiker heeft op de knop "2" gedrukt
        private void btn2_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "2" toe aan het tekstvak "Ingave PO"
            txtIngavePO.Text += "2";
        }

        // Gebruiker heeft op de knop "3" gedrukt
        private void btn3_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "3" toe aan het tekstvak "Ingave PO"
            txtIngavePO.Text += "3";
        }

        // Gebruiker heeft op de knop "4" gedrukt
        private void btn4_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "4" toe aan het tekstvak "Ingave PO"
            txtIngavePO.Text += "4";
        }

        // Gebruiker heeft op de knop "5" gedrukt
        private void btn5_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "5" toe aan het tekstvak "Ingave PO"
            txtIngavePO.Text += "5";
        }

        // Gebruiker heeft op de knop "6" gedrukt
        private void btn6_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "6" toe aan het tekstvak "Ingave PO"
            txtIngavePO.Text += "6";
        }

        // Gebruiker heeft op de knop "7" gedrukt
        private void btn7_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "7" toe aan het tekstvak "Ingave PO"
            txtIngavePO.Text += "7";
        }

        // Gebruiker heeft op de knop "8" gedrukt
        private void btn8_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "8" toe aan het tekstvak "Ingave PO"
            txtIngavePO.Text += "8";
        }

        // Gebruiker heeft op de knop "9" gedrukt
        private void btn9_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "9" toe aan het tekstvak "Ingave PO"
            txtIngavePO.Text += "9";
        }

        // Gebruiker heeft op de knop "0" gedrukt
        private void btn0_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "0" toe aan het tekstvak "Ingave PO"
            txtIngavePO.Text += "0";
        }

        // Gebruiker heeft op de knop "wis" gedrukt
        private void btnWis_Click(object sender, EventArgs e)
        {
            // wis het gehele tekstvak "Ingave PO"
            txtIngavePO.Text = "";
        }

        // Gebruiker heeft op de knop "OK" gedrukt
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Kopieer de inhoud van het tekstvak "Ingave PO" naar het tekstvak "PO" op het dashboard
            frmMain.txtPO.Text = txtIngavePO.Text;
            
            // Sluit het venster
            this.Close();
        }

        // Gebruiker heeft op de knop "annuleren" gedrukt
        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            // Sluit het venster
            this.Close();
        }

        // Venster is ingeladen
        private void frmPO_Load(object sender, EventArgs e)
        {
            // Zet de cursor focus op het tekstvak "Ingave PO", zodat operator onmiddelijk al kan inscannen
            txtIngavePO.Focus();
        }
    }
}
