using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMate
{
    public partial class FrmStatistika : Form
    {
        public FrmStatistika()
        {
            InitializeComponent();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            DateTime datumOd = dtpPocetak.Value.Date;
            DateTime datumDo = dtpKraj.Value.Date;

            if (datumOd > datumDo)
            {
                MessageBox.Show("Početni datum ne smije biti nakon završnog.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int korisnikId = Prijava.PrijavljeniKorisnik.ID_korisnik;
            List<Rashod> sviRashodi = RepozitorijRashoda.DohvatiRashodePoKategoriji(korisnikId, "");

            var filtrirani = sviRashodi
                .Where(r => r.Datum.Date >= datumOd && r.Datum.Date <= datumDo)
                .ToList();

            if (filtrirani.Count == 0)
            {
                MessageBox.Show("Nema rashoda za odabrano razdoblje.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<(string kategorija, float iznos)> podaciZaGraf = filtrirani
                .GroupBy(r => r.Kategorija)
                .Select(g => (g.Key, g.Sum(x => x.Iznos)))
                .ToList();

            FrmGraf forma = new FrmGraf(podaciZaGraf);
            forma.ShowDialog();
        }
    }
}
