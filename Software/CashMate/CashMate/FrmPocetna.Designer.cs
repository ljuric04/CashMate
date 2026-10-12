namespace CashMate
{
    partial class FrmPocetna
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
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(210, 115);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(170, 52);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos novog rashoda";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.Location = new System.Drawing.Point(210, 191);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(170, 52);
            this.btnPregled.TabIndex = 1;
            this.btnPregled.Text = "Pregled svih rashoda";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(210, 271);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(170, 52);
            this.btnStatistika.TabIndex = 2;
            this.btnStatistika.Text = "Prikaz statistike";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.Statistika_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(160, 52);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(272, 31);
            this.lblNaslov.TabIndex = 3;
            this.lblNaslov.Text = "Dobrodošli u Cashmate!";
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 381);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.btnUnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna stranica - CashMate";
            this.Load += new System.EventHandler(this.FrmPocetna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Label lblNaslov;
    }
}