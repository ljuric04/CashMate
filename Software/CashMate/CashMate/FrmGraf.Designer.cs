namespace CashMate
{
    partial class FrmGraf
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGraf
            // 
            chartArea3.Name = "ChartArea1";
            this.chartGraf.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartGraf.Legends.Add(legend3);
            this.chartGraf.Location = new System.Drawing.Point(108, 50);
            this.chartGraf.Name = "chartGraf";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartGraf.Series.Add(series3);
            this.chartGraf.Size = new System.Drawing.Size(443, 304);
            this.chartGraf.TabIndex = 0;
            this.chartGraf.Text = "chart1";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(262, 387);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(103, 35);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // FrmGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.chartGraf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmGraf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz grafa";
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf;
        private System.Windows.Forms.Button btnZatvori;
    }
}