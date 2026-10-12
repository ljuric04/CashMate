using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMate
{
    public class Rashod
    {
        public int ID_rashod { get; set; }
        public float Iznos { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
        public string Kategorija { get; set; }
        public int Korisnik { get; set; }
    }
}
