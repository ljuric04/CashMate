namespace CashMate
{
    partial class FrmStatistika
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
            this.lblObavijest = new System.Windows.Forms.Label();
            this.lblPocetak = new System.Windows.Forms.Label();
            this.lblKraj = new System.Windows.Forms.Label();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblObavijest
            // 
            this.lblObavijest.AutoSize = true;
            this.lblObavijest.Location = new System.Drawing.Point(28, 40);
            this.lblObavijest.Name = "lblObavijest";
            this.lblObavijest.Size = new System.Drawing.Size(314, 16);
            this.lblObavijest.TabIndex = 0;
            this.lblObavijest.Text = "Odaberite od kada do kada želite prikazati grafikon:";
            // 
            // lblPocetak
            // 
            this.lblPocetak.AutoSize = true;
            this.lblPocetak.Location = new System.Drawing.Point(28, 91);
            this.lblPocetak.Name = "lblPocetak";
            this.lblPocetak.Size = new System.Drawing.Size(102, 16);
            this.lblPocetak.TabIndex = 1;
            this.lblPocetak.Text = "Datum od kada:";
            // 
            // lblKraj
            // 
            this.lblKraj.AutoSize = true;
            this.lblKraj.Location = new System.Drawing.Point(28, 132);
            this.lblKraj.Name = "lblKraj";
            this.lblKraj.Size = new System.Drawing.Size(102, 16);
            this.lblKraj.TabIndex = 2;
            this.lblKraj.Text = "Datum do kada:";
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Location = new System.Drawing.Point(142, 86);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(200, 22);
            this.dtpPocetak.TabIndex = 3;
            // 
            // dtpKraj
            // 
            this.dtpKraj.Location = new System.Drawing.Point(142, 127);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(200, 22);
            this.dtpKraj.TabIndex = 4;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(127, 188);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(108, 38);
            this.btnPrikazi.TabIndex = 5;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // FrmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 253);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dtpKraj);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.lblKraj);
            this.Controls.Add(this.lblPocetak);
            this.Controls.Add(this.lblObavijest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStatistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz statistike";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObavijest;
        private System.Windows.Forms.Label lblPocetak;
        private System.Windows.Forms.Label lblKraj;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.Button btnPrikazi;
    }
}