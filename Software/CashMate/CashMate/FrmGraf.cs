using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CashMate
{
    public partial class FrmGraf : Form
    {
        public FrmGraf(List<(string Kategorija, float Iznos)> podaci)
        {
            InitializeComponent();
            PrikaziPodatke(podaci);
        }

        private void PrikaziPodatke(List<(string Kategorija, float Iznos)> podaci)
        {
            chartGraf.Series.Clear();

            Series serija = new Series
            {
                Name = "Rashodi po kategorijama",
                ChartType = SeriesChartType.Pie
            };

            foreach (var podatak in podaci)
            {
                serija.Points.AddXY(podatak.Kategorija, podatak.Iznos);
            }

            chartGraf.Series.Add(serija);
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}