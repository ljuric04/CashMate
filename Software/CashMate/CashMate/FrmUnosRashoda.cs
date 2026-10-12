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
    public partial class FrmUnosRashoda : Form
    {
        public FrmUnosRashoda()
        {
            InitializeComponent();
        }

        private void FrmUnosRashoda_Load(object sender, EventArgs e)
        {
            cmbKategorija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategorija.Items.Clear();
            cmbKategorija.Items.AddRange(new string[] { "Hrana", "Stanovanje", "Prijevoz", "Zabava", "Ostalo" });
            cmbKategorija.SelectedIndex = 0;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIznos.Text) || string.IsNullOrWhiteSpace(txtOpis.Text) || cmbKategorija.SelectedIndex == -1)
            {
                MessageBox.Show("Sva polja su obavezna.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(txtIznos.Text, out float iznos))
            {
                MessageBox.Show("Unesite ispravan broj za iznos.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Rashod noviRashod = new Rashod
            {
                Iznos = iznos,
                Datum = dtpDatum.Value,
                Opis = txtOpis.Text,
                Kategorija = cmbKategorija.SelectedItem.ToString(),
                Korisnik = Prijava.PrijavljeniKorisnik.ID_korisnik
            };

            bool uspjeh = RepozitorijRashoda.UnesiRashod(noviRashod);

            if (uspjeh)
            {
                MessageBox.Show("Rashod je uspješno spremljen!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Greška pri spremanju podataka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

