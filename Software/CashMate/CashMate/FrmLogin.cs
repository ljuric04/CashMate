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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string lozinka = txtLozinka.Text.Trim();


            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(lozinka))
            {
                MessageBox.Show("Molimo unesite korisničke podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Korisnik korisnik = KorisnikServis.PrijaviKorisnika(email, lozinka);

            if (korisnik != null)
            {
                Prijava.PrijavljeniKorisnik = korisnik;

                MessageBox.Show("Prijava uspješna! Dobrodošao na CashMate!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmPocetna forma = new FrmPocetna();
                this.Hide();
                forma.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Neispravni korisnički podaci.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
