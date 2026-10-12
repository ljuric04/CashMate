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
    public partial class FrmUrediRashod : Form
    {
        public Rashod RashodZaUredivanje { get; set; }

        public FrmUrediRashod(Rashod rashod)
        {
            InitializeComponent();
            RashodZaUredivanje = rashod;
        }
        private void FrmUrediRashod_Load(object sender, EventArgs e)
        {
            cmbKategorija.DropDownStyle = ComboBoxStyle.DropDownList;

            string[] kategorije = { "Hrana", "Stanovanje", "Prijevoz", "Zabava", "Ostalo" };
            cmbKategorija.Items.AddRange(kategorije);

            txtIznos.Text = RashodZaUredivanje.Iznos.ToString();
            dtpDatum.Value = RashodZaUredivanje.Datum;
            txtOpis.Text = RashodZaUredivanje.Opis;
            cmbKategorija.SelectedItem = RashodZaUredivanje.Kategorija;
        }
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIznos.Text) || string.IsNullOrWhiteSpace(txtOpis.Text) || cmbKategorija.SelectedIndex == -1)
            {
                MessageBox.Show("Sva polja su obavezna.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float iznos;
            bool ispravan = float.TryParse(txtIznos.Text, out iznos);
            if (!ispravan)
            {
                MessageBox.Show("Unesite ispravan broj za iznos.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RashodZaUredivanje.Iznos = iznos;
            RashodZaUredivanje.Datum = dtpDatum.Value;
            RashodZaUredivanje.Opis = txtOpis.Text;
            RashodZaUredivanje.Kategorija = cmbKategorija.SelectedItem.ToString();

            bool uspjeh = RepozitorijRashoda.AzurirajRashod(RashodZaUredivanje);

            if (uspjeh)
            {
                MessageBox.Show("Rashod je uspješno ažuriran!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
