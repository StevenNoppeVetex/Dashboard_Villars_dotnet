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
    }
}
