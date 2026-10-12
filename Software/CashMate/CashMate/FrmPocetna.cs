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
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void FrmPocetna_Load(object sender, EventArgs e)
        {

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            FrmUnosRashoda forma = new FrmUnosRashoda();
            forma.ShowDialog();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            FrmListaRashoda forma = new FrmListaRashoda();
            forma.ShowDialog();
        }

        private void Statistika_Click(object sender, EventArgs e)
        {
            FrmStatistika forma = new FrmStatistika();
            forma.ShowDialog();
        }
    }
}
