
namespace Dashboard_Villars_dotnet
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPO = new System.Windows.Forms.Label();
            this.txtPO = new System.Windows.Forms.TextBox();
            this.dgvDoek1 = new System.Windows.Forms.DataGridView();
            this.lblDoek1 = new System.Windows.Forms.Label();
            this.dgvMembraam_doek2 = new System.Windows.Forms.DataGridView();
            this.lblMembraam_doek2 = new System.Windows.Forms.Label();
            this.lblPassage = new System.Windows.Forms.Label();
            this.txtPassage = new System.Windows.Forms.TextBox();
            this.btnToevoegenDoek1 = new System.Windows.Forms.Button();
            this.btnToevoegenMembraam_doek2 = new System.Windows.Forms.Button();
            this.lblMachineStatus = new System.Windows.Forms.Label();
            this.txtMachineStatus = new System.Windows.Forms.TextBox();
            this.stsStatusStrip = new System.Windows.Forms.StatusStrip();
            this.stslblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnWisDoeken1 = new System.Windows.Forms.Button();
            this.btnWisMembramen_doeken2 = new System.Windows.Forms.Button();
            this.btnWisPO = new System.Windows.Forms.Button();
            this.pbxVetexLogo = new System.Windows.Forms.PictureBox();
            this.btnWijzigMetrageDoek1 = new System.Windows.Forms.Button();
            this.btnWijzigMetrageMembraam_doek2 = new System.Windows.Forms.Button();
            this.btnPrintLabel = new System.Windows.Forms.Button();
            this.btnGebeurtenis1 = new System.Windows.Forms.Button();
            this.btnGebeurtenis2 = new System.Windows.Forms.Button();
            this.btnGebeurtenis4 = new System.Windows.Forms.Button();
            this.btnGebeurtenis3 = new System.Windows.Forms.Button();
            this.btnGebeurtenis6 = new System.Windows.Forms.Button();
            this.btnGebeurtenis5 = new System.Windows.Forms.Button();
            this.btnGebeurtenis8 = new System.Windows.Forms.Button();
            this.btnGebeurtenis7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoek1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembraam_doek2)).BeginInit();
            this.stsStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVetexLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPO
            // 
            resources.ApplyResources(this.lblPO, "lblPO");
            this.lblPO.Name = "lblPO";
            // 
            // txtPO
            // 
            resources.ApplyResources(this.txtPO, "txtPO");
            this.txtPO.Name = "txtPO";
            this.txtPO.Click += new System.EventHandler(this.txtPO_Click);
            // 
            // dgvDoek1
            // 
            this.dgvDoek1.AllowUserToAddRows = false;
            this.dgvDoek1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoek1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoek1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoek1.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dgvDoek1, "dgvDoek1");
            this.dgvDoek1.Name = "dgvDoek1";
            this.dgvDoek1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoek1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            // 
            // lblDoek1
            // 
            resources.ApplyResources(this.lblDoek1, "lblDoek1");
            this.lblDoek1.Name = "lblDoek1";
            // 
            // dgvMembraam_doek2
            // 
            this.dgvMembraam_doek2.AllowUserToAddRows = false;
            this.dgvMembraam_doek2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembraam_doek2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMembraam_doek2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembraam_doek2.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.dgvMembraam_doek2, "dgvMembraam_doek2");
            this.dgvMembraam_doek2.Name = "dgvMembraam_doek2";
            this.dgvMembraam_doek2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembraam_doek2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            // 
            // lblMembraam_doek2
            // 
            resources.ApplyResources(this.lblMembraam_doek2, "lblMembraam_doek2");
            this.lblMembraam_doek2.Name = "lblMembraam_doek2";
            // 
            // lblPassage
            // 
            resources.ApplyResources(this.lblPassage, "lblPassage");
            this.lblPassage.Name = "lblPassage";
            // 
            // txtPassage
            // 
            resources.ApplyResources(this.txtPassage, "txtPassage");
            this.txtPassage.Name = "txtPassage";
            this.txtPassage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassage_MouseClick);
            this.txtPassage.TextChanged += new System.EventHandler(this.txtPassage_TextChanged);
            // 
            // btnToevoegenDoek1
            // 
            resources.ApplyResources(this.btnToevoegenDoek1, "btnToevoegenDoek1");
            this.btnToevoegenDoek1.Name = "btnToevoegenDoek1";
            this.btnToevoegenDoek1.UseVisualStyleBackColor = true;
            this.btnToevoegenDoek1.Click += new System.EventHandler(this.btnToevoegenDoek1_Click);
            // 
            // btnToevoegenMembraam_doek2
            // 
            resources.ApplyResources(this.btnToevoegenMembraam_doek2, "btnToevoegenMembraam_doek2");
            this.btnToevoegenMembraam_doek2.Name = "btnToevoegenMembraam_doek2";
            this.btnToevoegenMembraam_doek2.UseVisualStyleBackColor = true;
            this.btnToevoegenMembraam_doek2.Click += new System.EventHandler(this.btnToevoegenMembraam_doek2_Click);
            // 
            // lblMachineStatus
            // 
            resources.ApplyResources(this.lblMachineStatus, "lblMachineStatus");
            this.lblMachineStatus.Name = "lblMachineStatus";
            // 
            // txtMachineStatus
            // 
            resources.ApplyResources(this.txtMachineStatus, "txtMachineStatus");
            this.txtMachineStatus.Name = "txtMachineStatus";
            // 
            // stsStatusStrip
            // 
            this.stsStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stslblVersion});
            resources.ApplyResources(this.stsStatusStrip, "stsStatusStrip");
            this.stsStatusStrip.Name = "stsStatusStrip";
            // 
            // stslblVersion
            // 
            this.stslblVersion.Name = "stslblVersion";
            resources.ApplyResources(this.stslblVersion, "stslblVersion");
            // 
            // btnWisDoeken1
            // 
            resources.ApplyResources(this.btnWisDoeken1, "btnWisDoeken1");
            this.btnWisDoeken1.Name = "btnWisDoeken1";
            this.btnWisDoeken1.UseVisualStyleBackColor = true;
            this.btnWisDoeken1.Click += new System.EventHandler(this.btnWisDoeken1_Click);
            // 
            // btnWisMembramen_doeken2
            // 
            resources.ApplyResources(this.btnWisMembramen_doeken2, "btnWisMembramen_doeken2");
            this.btnWisMembramen_doeken2.Name = "btnWisMembramen_doeken2";
            this.btnWisMembramen_doeken2.UseVisualStyleBackColor = true;
            this.btnWisMembramen_doeken2.Click += new System.EventHandler(this.btnWisMembramen_doeken2_Click);
            // 
            // btnWisPO
            // 
            resources.ApplyResources(this.btnWisPO, "btnWisPO");
            this.btnWisPO.Name = "btnWisPO";
            this.btnWisPO.UseVisualStyleBackColor = true;
            this.btnWisPO.Click += new System.EventHandler(this.btnWisPO_Click);
            // 
            // pbxVetexLogo
            // 
            resources.ApplyResources(this.pbxVetexLogo, "pbxVetexLogo");
            this.pbxVetexLogo.Name = "pbxVetexLogo";
            this.pbxVetexLogo.TabStop = false;
            // 
            // btnWijzigMetrageDoek1
            // 
            resources.ApplyResources(this.btnWijzigMetrageDoek1, "btnWijzigMetrageDoek1");
            this.btnWijzigMetrageDoek1.Name = "btnWijzigMetrageDoek1";
            this.btnWijzigMetrageDoek1.UseVisualStyleBackColor = true;
            this.btnWijzigMetrageDoek1.Click += new System.EventHandler(this.btnWijzigMetrageDoek1_Click);
            // 
            // btnWijzigMetrageMembraam_doek2
            // 
            resources.ApplyResources(this.btnWijzigMetrageMembraam_doek2, "btnWijzigMetrageMembraam_doek2");
            this.btnWijzigMetrageMembraam_doek2.Name = "btnWijzigMetrageMembraam_doek2";
            this.btnWijzigMetrageMembraam_doek2.UseVisualStyleBackColor = true;
            this.btnWijzigMetrageMembraam_doek2.Click += new System.EventHandler(this.btnWijzigMetrageMembraam_doek2_Click);
            // 
            // btnPrintLabel
            // 
            resources.ApplyResources(this.btnPrintLabel, "btnPrintLabel");
            this.btnPrintLabel.Name = "btnPrintLabel";
            this.btnPrintLabel.UseVisualStyleBackColor = true;
            // 
            // btnGebeurtenis1
            // 
            resources.ApplyResources(this.btnGebeurtenis1, "btnGebeurtenis1");
            this.btnGebeurtenis1.Name = "btnGebeurtenis1";
            this.btnGebeurtenis1.UseVisualStyleBackColor = true;
            this.btnGebeurtenis1.Click += new System.EventHandler(this.btnGebeurtenis1_Click);
            // 
            // btnGebeurtenis2
            // 
            resources.ApplyResources(this.btnGebeurtenis2, "btnGebeurtenis2");
            this.btnGebeurtenis2.Name = "btnGebeurtenis2";
            this.btnGebeurtenis2.UseVisualStyleBackColor = true;
            this.btnGebeurtenis2.Click += new System.EventHandler(this.btnGebeurtenis2_Click);
            // 
            // btnGebeurtenis4
            // 
            resources.ApplyResources(this.btnGebeurtenis4, "btnGebeurtenis4");
            this.btnGebeurtenis4.Name = "btnGebeurtenis4";
            this.btnGebeurtenis4.UseVisualStyleBackColor = true;
            this.btnGebeurtenis4.Click += new System.EventHandler(this.btnGebeurtenis4_Click);
            // 
            // btnGebeurtenis3
            // 
            resources.ApplyResources(this.btnGebeurtenis3, "btnGebeurtenis3");
            this.btnGebeurtenis3.Name = "btnGebeurtenis3";
            this.btnGebeurtenis3.UseVisualStyleBackColor = true;
            this.btnGebeurtenis3.Click += new System.EventHandler(this.btnGebeurtenis3_Click);
            // 
            // btnGebeurtenis6
            // 
            resources.ApplyResources(this.btnGebeurtenis6, "btnGebeurtenis6");
            this.btnGebeurtenis6.Name = "btnGebeurtenis6";
            this.btnGebeurtenis6.UseVisualStyleBackColor = true;
            this.btnGebeurtenis6.Click += new System.EventHandler(this.btnGebeurtenis6_Click);
            // 
            // btnGebeurtenis5
            // 
            resources.ApplyResources(this.btnGebeurtenis5, "btnGebeurtenis5");
            this.btnGebeurtenis5.Name = "btnGebeurtenis5";
            this.btnGebeurtenis5.UseVisualStyleBackColor = true;
            this.btnGebeurtenis5.Click += new System.EventHandler(this.btnGebeurtenis5_Click);
            // 
            // btnGebeurtenis8
            // 
            resources.ApplyResources(this.btnGebeurtenis8, "btnGebeurtenis8");
            this.btnGebeurtenis8.Name = "btnGebeurtenis8";
            this.btnGebeurtenis8.UseVisualStyleBackColor = true;
            this.btnGebeurtenis8.Click += new System.EventHandler(this.btnGebeurtenis8_Click);
            // 
            // btnGebeurtenis7
            // 
            resources.ApplyResources(this.btnGebeurtenis7, "btnGebeurtenis7");
            this.btnGebeurtenis7.Name = "btnGebeurtenis7";
            this.btnGebeurtenis7.UseVisualStyleBackColor = true;
            this.btnGebeurtenis7.Click += new System.EventHandler(this.btnGebeurtenis7_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGebeurtenis8);
            this.Controls.Add(this.btnGebeurtenis7);
            this.Controls.Add(this.btnGebeurtenis6);
            this.Controls.Add(this.btnGebeurtenis5);
            this.Controls.Add(this.btnGebeurtenis4);
            this.Controls.Add(this.btnGebeurtenis3);
            this.Controls.Add(this.btnGebeurtenis2);
            this.Controls.Add(this.btnGebeurtenis1);
            this.Controls.Add(this.btnPrintLabel);
            this.Controls.Add(this.btnWijzigMetrageMembraam_doek2);
            this.Controls.Add(this.btnWijzigMetrageDoek1);
            this.Controls.Add(this.pbxVetexLogo);
            this.Controls.Add(this.btnWisPO);
            this.Controls.Add(this.btnWisMembramen_doeken2);
            this.Controls.Add(this.btnWisDoeken1);
            this.Controls.Add(this.stsStatusStrip);
            this.Controls.Add(this.txtMachineStatus);
            this.Controls.Add(this.lblMachineStatus);
            this.Controls.Add(this.btnToevoegenMembraam_doek2);
            this.Controls.Add(this.btnToevoegenDoek1);
            this.Controls.Add(this.txtPassage);
            this.Controls.Add(this.lblPassage);
            this.Controls.Add(this.lblMembraam_doek2);
            this.Controls.Add(this.dgvMembraam_doek2);
            this.Controls.Add(this.lblDoek1);
            this.Controls.Add(this.dgvDoek1);
            this.Controls.Add(this.txtPO);
            this.Controls.Add(this.lblPO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoek1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembraam_doek2)).EndInit();
            this.stsStatusStrip.ResumeLayout(false);
            this.stsStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVetexLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPO;
        private System.Windows.Forms.Label lblDoek1;
        private System.Windows.Forms.Label lblMembraam_doek2;
        private System.Windows.Forms.Label lblPassage;
        private System.Windows.Forms.Button btnToevoegenDoek1;
        private System.Windows.Forms.Button btnToevoegenMembraam_doek2;
        private System.Windows.Forms.Label lblMachineStatus;
        private System.Windows.Forms.TextBox txtMachineStatus;
        private System.Windows.Forms.StatusStrip stsStatusStrip;
        public System.Windows.Forms.TextBox txtPO;
        public System.Windows.Forms.DataGridView dgvDoek1;
        public System.Windows.Forms.DataGridView dgvMembraam_doek2;
        private System.Windows.Forms.Button btnWisDoeken1;
        private System.Windows.Forms.Button btnWisMembramen_doeken2;
        private System.Windows.Forms.Button btnWisPO;
        public System.Windows.Forms.TextBox txtPassage;
        private System.Windows.Forms.PictureBox pbxVetexLogo;
        private System.Windows.Forms.Button btnWijzigMetrageDoek1;
        private System.Windows.Forms.Button btnWijzigMetrageMembraam_doek2;
        private System.Windows.Forms.Button btnPrintLabel;
        private System.Windows.Forms.Button btnGebeurtenis1;
        private System.Windows.Forms.Button btnGebeurtenis2;
        private System.Windows.Forms.Button btnGebeurtenis4;
        private System.Windows.Forms.Button btnGebeurtenis3;
        private System.Windows.Forms.Button btnGebeurtenis6;
        private System.Windows.Forms.Button btnGebeurtenis5;
        private System.Windows.Forms.Button btnGebeurtenis8;
        private System.Windows.Forms.Button btnGebeurtenis7;
        private System.Windows.Forms.ToolStripStatusLabel stslblVersion;
    }
}

