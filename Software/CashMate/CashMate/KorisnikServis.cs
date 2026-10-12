using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMate
{
    public class KorisnikServis
    {
        public static Korisnik PrijaviKorisnika(string email, string lozinka)
        {
            return RepozitorijKorisnika.DohvatiKorisnika(email, lozinka);
        }
    }
}