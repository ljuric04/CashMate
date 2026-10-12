namespace CashMate
{
    partial class FrmUrediRashod
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.lblIznos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(246, 264);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(132, 33);
            this.btnOdustani.TabIndex = 20;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(89, 264);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(132, 33);
            this.btnSpremi.TabIndex = 19;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(178, 201);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(200, 24);
            this.cmbKategorija.TabIndex = 18;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(178, 109);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 17;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(178, 155);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(200, 22);
            this.txtOpis.TabIndex = 16;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(86, 201);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(71, 16);
            this.lblKategorija.TabIndex = 15;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(86, 158);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(38, 16);
            this.lblOpis.TabIndex = 14;
            this.lblOpis.Text = "Opis:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(86, 114);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(49, 16);
            this.lblDatum.TabIndex = 13;
            this.lblDatum.Text = "Datum:";
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(178, 68);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(200, 22);
            this.txtIznos.TabIndex = 12;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(86, 68);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(41, 16);
            this.lblIznos.TabIndex = 11;
            this.lblIznos.Text = "Iznos:";
            // 
            // FrmUrediRashod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 338);
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
            this.Name = "FrmUrediRashod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi rashod";
            this.Load += new System.EventHandler(this.FrmUrediRashod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label lblIznos;
    }
}