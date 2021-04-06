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
    public partial class frmMembraam_doek2 : Form
    {
        frmMain frmMain;                                                // nodig om aan de tekstvakken in het hoofdvenster te kunnen
        public frmMembraam_doek2(frmMain form)
        {
            InitializeComponent();
            this.frmMain = form;                                        // nodig om aan de tekstvakken in het hoofdvenster te kunnen
        }

        // venster is ingeladen
        private void frmMembraam_Load(object sender, EventArgs e)
        {
            // Zet de cursor focus op het tekstvak "Ingave Passage", zodat operator onmiddelijk al kan inscannen
            txtIngaveMembraam.Focus();
        }

        // Gebruiker heeft op de knop "wis" gedrukt
        private void btnWis_Click(object sender, EventArgs e)
        {
            // wis het gehele tekstvak
            txtIngaveMembraam.Text = "";
        }

        // Gebruiker heeft op de knop "OK" gedrukt
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Creëer een nieuwe rij in de datagridview "membraam/doek 2" in het hoofd venster en kopieer het tekstvak "ingave membraam/doek 2" naar de eerste kolom
            // Rijen worden eerst geteld en een nieuwe rij wordt toegevoegd
            string[] row = new string[] { (frmMain.dgvMembraam_doek2.RowCount + 1).ToString(), txtIngaveMembraam.Text, "0" };
            frmMain.dgvMembraam_doek2.Rows.Add(row);

            // sluit het venster
            this.Close();
        }

        // Gebruiker heeft op de knop "annuleren" gedrukt
        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            // sluit het venster
            this.Close();
        }
    }
}
