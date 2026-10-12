using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DBLayer;

namespace CashMate
{
    public class RepozitorijKorisnika
    {
        public static Korisnik DohvatiKorisnika(string email, string lozinka)
        {
            DB.OpenConnection();

            string sql = $"SELECT * FROM Korisnik WHERE Email = '{email}' AND Lozinka = '{lozinka}'";
            var reader = DB.GetDataReader(sql);

            Korisnik korisnik = null;

            if (reader.Read())
            {
                korisnik = new Korisnik
                {
                    ID_korisnik = int.Parse(reader["ID_korisnik"].ToString()),
                    Ime = reader["Ime"].ToString(),
                    Email = reader["Email"].ToString(),
                    Lozinka = reader["Lozinka"].ToString()
                };
            }

            reader.Close();
            DB.CloseConnection();

            return korisnik;
        }
    }
}