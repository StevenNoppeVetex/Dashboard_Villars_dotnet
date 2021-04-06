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
    public partial class frmPassage : Form
    {
        frmMain frmMain;                                            // nodig om aan de tekstvakken in het hoofdvenster te kunnen
        public frmPassage(frmMain form)
        {
            InitializeComponent();

            this.frmMain = form;                                    // nodig om aan de tekstvakken in het hoofdvenster te kunnen
        }

        // Venster is ingeladen
        private void frmPassage_Load(object sender, EventArgs e)
        {
            // Zet de cursor focus op het tekstvak "Ingave Passage", zodat operator onmiddelijk al kan inscannen
            txtIngavePassage.Focus();
        }

        // Gebruiker heeft op de knop "OK" gedrukt
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Controleer indien tekstvak niet leeg is!
            if (txtIngavePassage.Text != "")
            {
                // Controleer indien het tekstvak enkel een geheel getal bevat
                if (txtIngavePassage.Text.All(char.IsDigit))
                {
                    // Controleer indien het getal 1 of 2 is
                    if (int.Parse(txtIngavePassage.Text) < 1 || int.Parse(txtIngavePassage.Text) > 2)
                    {
                        // Getal is niet gelijk aan 1 of 2, , vul een standaard waarde "1" in
                        MessageBox.Show("Verkeerde ingave! Er wordt overgeschakeld naar passage 1!");
                        txtIngavePassage.Text = "1";
                    }
                }
                else
                {
                    // Tekstvak bevat geen geheel getal, vul een standaard waarde "1" in
                    MessageBox.Show("Verkeerde ingave! Er wordt overgeschakeld naar passage 1!");
                    txtIngavePassage.Text = "1";
                }
            }
            else
            {
                // Tekstvak is leeg, vul een standaard waarde "1" in
                MessageBox.Show("Verkeerde ingave! Er wordt overgeschakeld naar passage 1!");
                txtIngavePassage.Text = "1";
            }

            // Kopieer de inhoud van het tekstvak "Ingave passage" naar het tekstvak "Passage" op het dashboard
            frmMain.txtPassage.Text = txtIngavePassage.Text;
            this.Close();
        }

        // Gebruiker heeft op de knop "annuleren" gedrukt
        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            // Doe niets
            this.Close();
        }

        // Gebruiker heeft op de knop "1" gedrukt
        private void btn1_Click(object sender, EventArgs e)
        {
            // Gebruiker heeft op de knop "1" gedrukt
            txtIngavePassage.Text = "1";
        }

        // Gebruiker heeft op de knop "2" gedrukt
        private void btn2_Click(object sender, EventArgs e)
        {
            // Gebruiker heeft op de knop "2" gedrukt
            txtIngavePassage.Text = "2";
        }
    }
}
