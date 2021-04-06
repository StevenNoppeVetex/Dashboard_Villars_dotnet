
namespace Dashboard_Villars_dotnet
{
    partial class frmMembraam_doek2
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
            this.btnWis = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtIngaveMembraam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWis
            // 
            this.btnWis.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWis.Location = new System.Drawing.Point(372, 62);
            this.btnWis.Name = "btnWis";
            this.btnWis.Size = new System.Drawing.Size(126, 60);
            this.btnWis.TabIndex = 5;
            this.btnWis.Text = "WIS";
            this.btnWis.UseVisualStyleBackColor = true;
            this.btnWis.Click += new System.EventHandler(this.btnWis_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuleren.Location = new System.Drawing.Point(12, 389);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(300, 60);
            this.btnAnnuleren.TabIndex = 6;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(318, 389);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(180, 60);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtIngaveMembraam
            // 
            this.txtIngaveMembraam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngaveMembraam.Location = new System.Drawing.Point(12, 12);
            this.txtIngaveMembraam.Name = "txtIngaveMembraam";
            this.txtIngaveMembraam.Size = new System.Drawing.Size(486, 44);
            this.txtIngaveMembraam.TabIndex = 4;
            // 
            // frmMembraam_doek2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 461);
            this.Controls.Add(this.btnWis);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtIngaveMembraam);
            this.Name = "frmMembraam_doek2";
            this.Text = "Ingave membraam/doek 2";
            this.Load += new System.EventHandler(this.frmMembraam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWis;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtIngaveMembraam;
    }
}