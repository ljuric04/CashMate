namespace CashMate
{
    partial class FrmListaRashoda
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
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.dgvRashod = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnUredi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRashod)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(679, 63);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 31);
            this.btnPretrazi.TabIndex = 0;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.Location = new System.Drawing.Point(50, 63);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(191, 16);
            this.lblPretrazi.TabIndex = 1;
            this.lblPretrazi.Text = "Odaberi kategoriju za pretragu:";
            // 
            // dgvRashod
            // 
            this.dgvRashod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRashod.Location = new System.Drawing.Point(53, 114);
            this.dgvRashod.Name = "dgvRashod";
            this.dgvRashod.RowHeadersWidth = 51;
            this.dgvRashod.RowTemplate.Height = 24;
            this.dgvRashod.Size = new System.Drawing.Size(701, 296);
            this.dgvRashod.TabIndex = 3;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(143, 435);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 31);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(679, 435);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 31);
            this.btnZatvori.TabIndex = 6;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(247, 63);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(100, 22);
            this.txtPretrazi.TabIndex = 2;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(53, 435);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 31);
            this.btnUredi.TabIndex = 7;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // FrmListaRashoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 491);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvRashod);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.btnPretrazi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListaRashoda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled svih rashoda";
            this.Load += new System.EventHandler(this.FrmListaRashoda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRashod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.DataGridView dgvRashod;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnUredi;
    }
}