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
    public partial class FrmListaRashoda : Form
    {
        public FrmListaRashoda()
        {
            InitializeComponent();
        }

        private void FrmListaRashoda_Load(object sender, EventArgs e)
        {
            UcitajSveRashode();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string kategorija = txtPretrazi.Text.Trim();
            if (string.IsNullOrWhiteSpace(kategorija))
            {
                UcitajSveRashode();
            }
            else
            {
                UcitajRashodePoKategoriji(kategorija);
            }
        }

        private void UcitajSveRashode()
        {
            int korisnikId = Prijava.PrijavljeniKorisnik.ID_korisnik;
            List<Rashod> lista = RepozitorijRashoda.DohvatiRashodePoKategoriji(korisnikId, "");
            dgvRashod.DataSource = lista;
            dgvRashod.Columns["Korisnik"].Visible = false;
        }

        private void UcitajRashodePoKategoriji(string kategorija)
        {
            int korisnikId = Prijava.PrijavljeniKorisnik.ID_korisnik;
            List<Rashod> lista = RepozitorijRashoda.DohvatiRashodePoKategoriji(korisnikId, kategorija);
            dgvRashod.DataSource = lista;
            dgvRashod.Columns["Korisnik"].Visible = false;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvRashod.CurrentRow != null)
            {
                Rashod odabrani = dgvRashod.CurrentRow.DataBoundItem as Rashod;

                if (odabrani != null)
                {
                    DialogResult rezultat = MessageBox.Show("Želite li obrisati odabrani rashod?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rezultat == DialogResult.Yes)
                    {
                        bool uspjeh = RepozitorijRashoda.ObrisiRashod(odabrani.ID_rashod);
                        if (uspjeh)
                        {
                            MessageBox.Show("Rashod obrisan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UcitajSveRashode();
                        }
                        else
                        {
                            MessageBox.Show("Greška pri brisanju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }
        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvRashod.CurrentRow != null)
            {
                Rashod odabrani = dgvRashod.CurrentRow.DataBoundItem as Rashod;

                if (odabrani != null)
                {
                    FrmUrediRashod forma = new FrmUrediRashod(odabrani);
                    forma.ShowDialog();

                    UcitajSveRashode(); 
                }
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
