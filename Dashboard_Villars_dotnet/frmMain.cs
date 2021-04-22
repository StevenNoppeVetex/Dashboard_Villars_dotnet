﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Dashboard applicatie voor de Villars machine v0.3.3
 * 
 * GitHub pagina : 
 * ---------------
 * 
 * https://github.com/StevenNoppeVetex/Dashboard_Villars_dotnet
 * 
 * Geschiedenis :
 * --------------
 * 21 maart 2021    - V0.1.0 :  - Eerste versie
 * 01 april 2021    - V0.2.0 :  - Bij 2de passage wordt er geen membraam tegen het doek gelamineerd, maar een 2 de doek.
 *                                Dit werd gewijzigd in de applicatie zodat, wanneer de operator de 2 de passage kiest, er visueel op het hoofdscherm 
 *                                alles wijzigt om aan te duiden dat er momenteel een 2de doek gelamineerd wordt i.p.v. een membraam.
 *                              - De ingave van de passage werd verbeterd om foutieve ingave op te vangen. Enkel een cijfer 1 of 2 is nog toegelaten.
 * 02 april 2021    - V0.3.0 :  - Toevoegen 8 knoppen voor registratie van gebeurtenissen
 *                              - TabIndex van de knoppen, tekstvelden, ... in orde brengen
 *                              - Source-code voorzien van commentaren
 * 06 april 2021    - V0.3.1 :  - Source-code voorzien van commentaren
 *                              - Wijzigen OnTimedEvent5sec : Indien geen actieve verbinding met de PLC, timer verlaten en geen verdere code meer uitvoeren in die timer
 *                              - Wijzigen frmMain_load : Onmiddelijk starten 5 seconden timer
 *                              - Timer enable / disable uit de click events verwijderd van de PLC verbinding/verbreken knoppen
 * 20 april 2021    - V0.3.2 :  - Bug fix : "wis" toets werkte niet in venster metrage ingave
 * 22 april 2021    - V0.3.3 :  - Wijzigen grootte van hoofdvenster naar 1024x768, zodat deze fullscreen op de panel PC past.
 *                              - Aanpassen grootte van knoppen, tekstvakken, layout... op hoofdvenster
 *                              - Maximaliseer hoofdvenster bij opstarten applicatie
 *                              - Zet focus op hoofdvenster bij opstarten applicatie
 *                           
 * TODO :
 * ------
 * - automatisch verbinden met PLC bij opstart applicatie, bij geen verbinding evt. na een delay opnieuw proberen te connecteren
 * - verbinding met azure data lake database : - gebeurtenissen registreren
 *                                             - wegschrijven PO
 * - verbinding met azure (?) SQL database   : - wegschrijven PO, doek 1, membraam/doek 2 nummer, membraam/doek 2 metrage
 */

namespace Dashboard_Villars_dotnet
{
    public partial class frmMain : Form
    {
        // object aanmaken voor connectie met PLC Villars machine
        private CSiemensS7 VillarsPLC                                   = new CSiemensS7();
        
        // aanmaken string voor ontvangen PLC data
        private string strPLCData                                       = "";

        // aanmaken systeem timer voor ophalen PLC data
        private static System.Timers.Timer timer5sec = new System.Timers.Timer();

        // Wanneer er een connectie is met de PLC, start deze timer
        // elke 5 seconden word er data opgevraagd
        private void OnTimedEvent5sec(Object source, System.Timers.ElapsedEventArgs e)
        {
            // Controleer indien er een actieve verbinding is met de PLC
            if (!VillarsPLC.PLCconnected())
            {
                // indien geen actieve verbinding, verlaat de timer
                return;
            }
            
            string strMachineStatus;
            
            // Ophalen info uit "App.config" bestand
            // De machine status wordt bewaard in een datablock in de hoofd-PLC van de Villars
            int iMachineStatusDataBlock                                 = Properties.Settings.Default.PLC_MachineStatus_DataBlock;          // DataBlock nummer
            int iMAchineStatusMemoryLocation                            = Properties.Settings.Default.PLC_MachineStatus_MemoryLocation;     // Geheugen locatie in DataBlock

            // Initialiseren parameters voor ophalen status machine
            VillarsPLC.DataDBnumber                                     = iMachineStatusDataBlock;                                          // DataBlock nummer
            VillarsPLC.DataLocation                                     = iMAchineStatusMemoryLocation;                                     // Geheugen locatie in DataBlock
            VillarsPLC.DataType                                         = "sint";                                                           // Machine status in de PLC is van het type short int
            VillarsPLC.DataLength                                       = "byte";                                                           // Machine status in de PLC is 1 byte groot
            VillarsPLC.DataArea                                         = "DB";                                                             // Machine status zal uitgelezen worden uit een DataBlock

            // Ophalen status van de machine uit de PLC
            strPLCData = VillarsPLC.GetPLCData();
            
            // Afhankelijk van de uitgelezen data wijzigen we het tekstvak met de huidige machine status
            switch (int.Parse(strPLCData))
            {
                case 0:
                    {
                        // Machine uit
                        strMachineStatus                                = "Machine uit";
                        txtMachineStatus.BackColor                      = Color.LightBlue;
                        break;
                    }
                case 1:
                    {
                        // Machine aan : stuurkast aangelegd
                        strMachineStatus                                = "Machine aan";
                        txtMachineStatus.BackColor                      = Color.LightYellow;
                        break;
                    }
                case 2:
                    {
                        // Machine in productie : min. snelheid 1 m/min & coating mes in sjabloon staat neer
                        strMachineStatus                                = "Machine in productie";
                        txtMachineStatus.BackColor                      = Color.LightGreen;
                        break;
                    }
                default:
                    {
                        // Indien geen van bovenstaande, geef een algemene status aan
                        strMachineStatus                                = "Geen machine status";
                        txtMachineStatus.BackColor                      = SystemColors.Control;
                        break;
                    }
            }

            // Status machine weergeven in tekstvak
            if (txtMachineStatus.InvokeRequired)
            {
                txtMachineStatus.Invoke(new MethodInvoker(delegate
                {
                    txtMachineStatus.Text = strMachineStatus;
                }));
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtPO_Click(object sender, EventArgs e)
        {
            // Open het venster om het PO nummer te wijzigen
            // We geven dit formulier mee, zodat het nieuwe venster het tekstvak "PO" kan invullen
            frmPO frmPO                                                 = new frmPO(this);
            frmPO.ShowDialog();
        }

        private void btnToevoegenDoek1_Click(object sender, EventArgs e)
        {
            // Open het venster om een doek toe te voegen
            // We geven dit formulier mee, zodat het nieuwe venster de datagridview kan invullen
            frmDoek frmDoek                                             = new frmDoek(this);
            frmDoek.ShowDialog();
        }

        // hoofdvenster is ingeladen
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Instellen datagridview voor de eerste doek
            dgvDoek1.SelectionMode                                      = DataGridViewSelectionMode.FullRowSelect;
            dgvDoek1.RowTemplate.Height                                 = 40;
            dgvDoek1.ColumnCount                                        = 3;
            dgvDoek1.DefaultCellStyle.Font                              = new Font("Microsoft Sans Serif", 14.0F);
            dgvDoek1.DefaultCellStyle.Alignment                         = DataGridViewContentAlignment.MiddleCenter;
            dgvDoek1.ColumnHeadersDefaultCellStyle.Font                 = new Font("Microsoft Sans Serif", 14.0F);
            dgvDoek1.ColumnHeadersDefaultCellStyle.Alignment            = DataGridViewContentAlignment.MiddleCenter;

            dgvDoek1.Columns[0].Name                                    = "nr.";
            dgvDoek1.Columns[0].Width                                   = 30;

            dgvDoek1.Columns[1].Name                                    = "code";
            dgvDoek1.Columns[1].Width                                   = 250;

            dgvDoek1.Columns[2].Name                                    = "metrage";
            dgvDoek1.Columns[2].Width                                   = 100;

            // Instellen datagridview voor het membraam of tweede doek
            dgvMembraam_doek2.SelectionMode                             = DataGridViewSelectionMode.FullRowSelect;
            dgvMembraam_doek2.RowTemplate.Height                        = 40;
            dgvMembraam_doek2.ColumnCount                               = 3;
            dgvMembraam_doek2.DefaultCellStyle.Font                     = new Font("Microsoft Sans Serif", 14.0F);
            dgvMembraam_doek2.DefaultCellStyle.Alignment                = DataGridViewContentAlignment.MiddleCenter;
            dgvMembraam_doek2.ColumnHeadersDefaultCellStyle.Font        = new Font("Microsoft Sans Serif", 14.0F);
            dgvMembraam_doek2.ColumnHeadersDefaultCellStyle.Alignment   = DataGridViewContentAlignment.MiddleCenter;

            dgvMembraam_doek2.Columns[0].Name                           = "nr.";
            dgvMembraam_doek2.Columns[0].Width                          = 30;

            dgvMembraam_doek2.Columns[1].Name                           = "code";
            dgvMembraam_doek2.Columns[1].Width                          = 250;

            dgvMembraam_doek2.Columns[2].Name                           = "metrage";
            dgvMembraam_doek2.Columns[2].Width                          = 100;

            // Instellen 5 seconden timer om data uit PLC te lezen
            timer5sec.Elapsed                                          += OnTimedEvent5sec;                     // Welke functie aan te roepen bij verstrijken tijd
            timer5sec.AutoReset                                         = true;                                 // Automatisch resetten na bereiken tijd en opnieuw starten
            timer5sec.Interval                                          = 5000;                                 // Timer van 5000 ms = 5 seconden
            timer5sec.Enabled                                           = true;                                 // Start de timer

            // Maximaliseer venster
            this.Focus();
            this.WindowState = FormWindowState.Maximized;
        }

        // Gebruiker heeft op de knop "toevoegen membraam / doek 2" gedrukt
        private void btnToevoegenMembraam_doek2_Click(object sender, EventArgs e)
        {
            // Open het venster om een nieuwe membraam rol of 2de doek in te geven
            // We geven dit formulier mee, zodat het nieuwe venster de datagridview kan invullen
            frmMembraam_doek2 frmMembraam_doek2                         = new frmMembraam_doek2(this);
            frmMembraam_doek2.ShowDialog();
        }

        // Gebruiker heeft op de knop "wis doeken 1" gedrukt
        private void btnWisDoeken1_Click(object sender, EventArgs e)
        {
            // Wis het gehele datagridview van de eerste doeken
            dgvDoek1.Rows.Clear();
        }

        // Gebruiker heeft op de knop "wis membramen/doeken 2" gedrukt
        private void btnWisMembramen_doeken2_Click(object sender, EventArgs e)
        {
            // Wis het gehele datagridview van de membramen / tweede doeken
            dgvMembraam_doek2.Rows.Clear();
        }

        // Gebruiker heeft op de knop "wis PO" gedrukt
        private void btnWisPO_Click(object sender, EventArgs e)
        {
            // Wis het textvakje met PO nummer
            txtPO.Text                                                  = "";
        }

        // Gebruiker heeft op de knop "passage" gedrukt
        private void txtPassage_MouseClick(object sender, MouseEventArgs e)
        {
            // Open het venster om een passage te kiezen
            // We geven dit formulier mee, zodat het nieuwe venster het tekstvak "passage" kan invullen
            frmPassage frmPassage                                       = new frmPassage(this);
            frmPassage.ShowDialog();
        }

        // Gebruiker heeft op de knop "PLC verbinden" gedrukt
        private void btnPLCVerbinding_Click(object sender, EventArgs e)
        {
            // PLC verbinding opzetten

            // Haal info uit het "App.config" bestand
            string strIPAddress                                         = Properties.Settings.Default.PLC_IP_Address.ToString();        // IP adres van de PLC
            int iRack                                                   = Properties.Settings.Default.PLC_Rack;                         // Rack nummer
            int iSlot                                                   = Properties.Settings.Default.PLC_Slot;                         // Slot nummer

            // Probeer een verbinding te leggen met de PLC van de Villars machine (Siemens Simatic S7-1500 PLC)
            int iResult                                                 = VillarsPLC.ConnectTo("Villars", strIPAddress, iRack, iSlot);

            // PLC is verbonden indien resultaat gelijk is aan "0"
            if (iResult == 0)
            {
                stslblVerbindingPLC.Text                                = "PLC : Verbonden";
                btnPLCVerbinding.Enabled                                = false;
                btnPLCAfkoppelen.Enabled                                = true;
            }
            else
                MessageBox.Show("Kan geen verbinding maken met de PLC.\n Controleer de ethernetverbinding!", 
                    "Verbindingsfout!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Gebruiker heeft op de knop "PLC afkoppelen" gedrukt
        private void btnPLCAfkoppelen_Click(object sender, EventArgs e)
        {
            // Probeer de verbinding af te sluiten met de PLC van de Villars machine (Siemens Simatic S7-1500 PLC)
            int iResult                                                 = VillarsPLC.Disconnect();

            // PLC is correct afgesloten indien resultaat gelijk is aan "0"
            if (iResult == 0)
            {
                stslblVerbindingPLC.Text                                = "PLC : Geen verbinding";
                txtMachineStatus.Text                                   = "Geen machine status";
                btnPLCVerbinding.Enabled                                = true;
                btnPLCAfkoppelen.Enabled                                = false;
                txtMachineStatus.BackColor                              = SystemColors.Control;
            }
        }

        // Gebruiker heeft op de knop "wijzig metrage doek 1" gedrukt
        private void btnWijzigMetrageDoek1_Click(object sender, EventArgs e)
        {
            // controleer indien de datagridview wel rijen bevat
            if (dgvDoek1.RowCount == 0)
            {
                MessageBox.Show("Er zijn nog geen doeken ingegeven!");
            }
            else
            {
                // Controleer welke rij er geselecteerd is
                if (dgvDoek1.SelectedRows.Count > 0)
                {
                    // Open het venster om de metrage in te geven
                    // We geven dit formulier mee, zodat het nieuwe venster de datagrid view kan wijzigen
                    // We geven ook een "0" mee om aan te duiden dat het over doek 1 gaat
                    frmMetrage frmMetrage                               = new frmMetrage(this, 0);
                    frmMetrage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Gelieve een doek te selecteren!");
                }
            }
        }

        // Gebruiker heeft op de knop "wijzig metrage membraam / doek 2" gedrukt
        private void btnWijzigMetrageMembraam_doek2_Click(object sender, EventArgs e)
        {
            // controleer indien de datagridview wel rijen bevat
            if (dgvMembraam_doek2.RowCount == 0)
            {
                MessageBox.Show("Er zijn nog geen membramen ingegeven!");
            }
            else
            {
                // Controleer welke rij er geselecteerd is
                if (dgvMembraam_doek2.SelectedRows.Count > 0)
                {
                    // Open het venster om de metrage in te geven
                    // We geven dit formulier mee, zodat het nieuwe venster de datagrid view kan wijzigen
                    // We geven ook een "1" mee om aan te duiden dat het over membraam / doek 2 gaat
                    frmMetrage frmMetrage                               = new frmMetrage(this, 1);
                    frmMetrage.ShowDialog();
                }
                else
                {
                    // Er is geen membraam / doek 2 geselecteerd
                    MessageBox.Show("Gelieve een membraam / 2de doek te selecteren!");
                }
            }
        }

        // Het tekstvak "Passage" werd gewijzigd (via het venster "ingave passage")
        private void txtPassage_TextChanged(object sender, EventArgs e)
        {
            // controleer de inhoud van het tekstvak "passage"
            switch (txtPassage.Text)
            {
                // passage 1 => membraam / doek 2 = membraam
                case "1":
                    lblMembraam_doek2.Text                              = "Membraam :";
                    btnToevoegenMembraam_doek2.Text                     = "Toevoegen membraam";
                    btnWisMembramen_doeken2.Text                        = "Wis membramen";
                    break;
                
                // passage 2 => membraam / doek 2 = doek 2
                case "2":
                    lblMembraam_doek2.Text                              = "Doek 2 :";
                    btnToevoegenMembraam_doek2.Text                     = "Toevoegen doek 2";
                    btnWisMembramen_doeken2.Text                        = "Wis doeken 2";
                    break;

                // default => membraam / doek 2 = membraam
                default:
                    lblMembraam_doek2.Text                              = "Membraam :";
                    btnToevoegenMembraam_doek2.Text                     = "Toevoegen membraam";
                    btnWisMembramen_doeken2.Text                        = "Wis membramen";
                    break;
            }
        }

        // de gebruiker heeft op de knop "gebeurtenis 1" gedrukt
        private void btnGebeurtenis1_Click(object sender, EventArgs e)
        {

        }

        // de gebruiker heeft op de knop "gebeurtenis 2" gedrukt
        private void btnGebeurtenis2_Click(object sender, EventArgs e)
        {

        }

        // de gebruiker heeft op de knop "gebeurtenis 3" gedrukt
        private void btnGebeurtenis3_Click(object sender, EventArgs e)
        {

        }

        // de gebruiker heeft op de knop "gebeurtenis 4" gedrukt
        private void btnGebeurtenis4_Click(object sender, EventArgs e)
        {

        }

        // de gebruiker heeft op de knop "gebeurtenis 5" gedrukt
        private void btnGebeurtenis5_Click(object sender, EventArgs e)
        {

        }

        // de gebruiker heeft op de knop "gebeurtenis 6" gedrukt
        private void btnGebeurtenis6_Click(object sender, EventArgs e)
        {

        }

        // de gebruiker heeft op de knop "gebeurtenis 7" gedrukt
        private void btnGebeurtenis7_Click(object sender, EventArgs e)
        {

        }

        // de gebruiker heeft op de knop "gebeurtenis 8" gedrukt
        private void btnGebeurtenis8_Click(object sender, EventArgs e)
        {

        }
    }
}
