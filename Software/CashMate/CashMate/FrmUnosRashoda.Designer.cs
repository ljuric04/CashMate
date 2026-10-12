namespace CashMate
{
    partial class FrmUnosRashoda
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
            this.lblIznos = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(81, 53);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(41, 16);
            this.lblIznos.TabIndex = 0;
            this.lblIznos.Text = "Iznos:";
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(173, 53);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(200, 22);
            this.txtIznos.TabIndex = 1;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(81, 99);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(49, 16);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(81, 143);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(38, 16);
            this.lblOpis.TabIndex = 3;
            this.lblOpis.Text = "Opis:";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(81, 186);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(71, 16);
            this.lblKategorija.TabIndex = 4;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(173, 140);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(200, 22);
            this.txtOpis.TabIndex = 6;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(173, 94);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 7;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(173, 186);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(200, 24);
            this.cmbKategorija.TabIndex = 8;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(84, 249);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(132, 33);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(241, 249);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(132, 33);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmUnosRashoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 309);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.lblIznos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUnosRashoda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos rashoda";
            this.Load += new System.EventHandler(this.FrmUnosRashoda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
    }
}