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
    public partial class frmMetrage : Form
    {
        frmMain m_frmMain;                                      // nodig om aan de tekstvakken in het hoofdvenster te kunnen
        int m_materiaal;                                        // Over welk materiaal gaat het? 0 = doek 1, 1 = membraam/doek 2
        
        public frmMetrage(frmMain form, int materiaal)
        {
            InitializeComponent();

            this.m_frmMain = form;                              // nodig om aan de tekstvakken in het hoofdvenster te kunnen

            // Over welk materiaal gaat het? 0 = doek 1, 1 = membraam/doek 2
            switch (materiaal)
            {
                // Materiaal is doek 1
                case 0:
                    {
                        this.m_materiaal = 0;
                        break;
                    }
                // Materiaal is membraam/doek 2
                case 1:
                    {
                        this.m_materiaal = 1;
                        break;
                    }
                // default materiaal is doek 1
                default:
                    {
                        this.m_materiaal = 0;
                        break;
                    }
            }

        }

        // Gebruiker heeft op de knop "1" gedrukt
        private void btn1_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "1" toe aan het tekstvak "Ingave metrage"
            txtIngaveMetrage.Text += "1";
        }

        // Gebruiker heeft op de knop "2" gedrukt
        private void btn2_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "2" toe aan het tekstvak "Ingave metrage"
            txtIngaveMetrage.Text += "2";
        }

        // Gebruiker heeft op de knop "3" gedrukt
        private void btn3_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "3" toe aan het tekstvak "Ingave metrage"
            txtIngaveMetrage.Text += "3";
        }

        // Gebruiker heeft op de knop "4" gedrukt
        private void btn4_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "4" toe aan het tekstvak "Ingave metrage"
            txtIngaveMetrage.Text += "4";
        }

        // Gebruiker heeft op de knop "5" gedrukt
        private void btn5_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "5" toe aan het tekstvak "Ingave metrage"
            txtIngaveMetrage.Text += "5";
        }

        // Gebruiker heeft op de knop "6" gedrukt
        private void btn6_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "6" toe aan het tekstvak "Ingave metrage"
            txtIngaveMetrage.Text += "6";
        }

        // Gebruiker heeft op de knop "7" gedrukt
        private void btn7_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "7" toe aan het tekstvak "Ingave metrage"
            txtIngaveMetrage.Text += "7";
        }

        // Gebruiker heeft op de knop "8" gedrukt
        private void btn8_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "8" toe aan het tekstvak "Ingave metrage"
            txtIngaveMetrage.Text += "8";
        }

        // Gebruiker heeft op de knop "9" gedrukt
        private void btn9_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "9" toe aan het tekstvak "Ingave metrage"
            txtIngaveMetrage.Text += "9";
        }

        // Gebruiker heeft op de knop "0" gedrukt
        private void btn0_Click(object sender, EventArgs e)
        {
            // Voeg de tekst "0" toe aan het tekstvak "Ingave metrage"
            txtIngaveMetrage.Text += "0";
        }

        // Gebruiker heeft op de knop "wis" gedrukt
        private void btnWis_Click(object sender, EventArgs e)
        {
            txtIngaveMetrage.Text += "";
        }

        // Gebruiker heeft op de knop "annuleren" gedrukt
        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            // Sluit venster zonder iets te doen
            this.Close();
        }

        // Gebruiker heeft op de knop "OK" gedrukt
        private void btnOK_Click(object sender, EventArgs e)
        {
            // controleer over welk materiaal het gaat : 0 = doek, 1 = membraam/doek 2
            switch(m_materiaal)
            {
                // materiaal is doek
                case 0:
                    {
                        m_frmMain.dgvDoek1.CurrentRow.Cells[2].Value = txtIngaveMetrage.Text;
                        break;
                    }
                // materiaal is membraam/doek 2   
                case 1:
                    {
                        m_frmMain.dgvMembraam_doek2.CurrentRow.Cells[2].Value = txtIngaveMetrage.Text;
                        break;
                    }
                // default materiaal is doek
                default:
                    {
                        m_frmMain.dgvDoek1.CurrentRow.Cells[2].Value = txtIngaveMetrage.Text;
                        break;
                    }
            }

            // sluit het venster
            this.Close();
        }
    }
}
