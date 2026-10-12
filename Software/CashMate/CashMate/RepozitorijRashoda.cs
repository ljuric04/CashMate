using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace CashMate
{
    public class RepozitorijRashoda
    {
        public static bool UnesiRashod(Rashod r)
        {
            DB.OpenConnection();

            string sql = $"INSERT INTO Rashod (Iznos, Datum, Opis, Kategorija, Korisnik) " +
                         $"VALUES ('{r.Iznos}', '{r.Datum:yyyy-MM-dd}', '{r.Opis}', '{r.Kategorija}', '{r.Korisnik}')";

            int rezultat = DB.ExecuteCommand(sql);

            DB.CloseConnection();

            return rezultat > 0;
        }

        public static List<Rashod> DohvatiRashodePoKategoriji(int korisnikId, string kategorija)
        {
            List<Rashod> lista = new List<Rashod>();

            DB.OpenConnection();

            string sql = $"SELECT * FROM Rashod WHERE Korisnik = {korisnikId}";

            if (!string.IsNullOrWhiteSpace(kategorija))
            {
                sql += $" AND Kategorija LIKE '%{kategorija}%'";
            }

            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Rashod r = new Rashod
                {
                    ID_rashod = int.Parse(reader["ID_rashod"].ToString()),
                    Iznos = float.Parse(reader["Iznos"].ToString()),
                    Datum = DateTime.Parse(reader["Datum"].ToString()),
                    Opis = reader["Opis"].ToString(),
                    Kategorija = reader["Kategorija"].ToString(),
                    Korisnik = int.Parse(reader["Korisnik"].ToString())
                };

                lista.Add(r);
            }

            reader.Close();
            DB.CloseConnection();

            return lista;
        }

        public static bool ObrisiRashod(int idRashod)
        {
            DB.OpenConnection();

            string sql = $"DELETE FROM Rashod WHERE ID_rashod = {idRashod}";

            int brojRedova = DB.ExecuteCommand(sql);

            DB.CloseConnection();

            return brojRedova > 0;
        }

        public static bool AzurirajRashod(Rashod r)
        {
            DB.OpenConnection();

            string sql = $"UPDATE Rashod SET Iznos = '{r.Iznos}', Datum = '{r.Datum:yyyy-MM-dd}', Opis = '{r.Opis}', Kategorija = '{r.Kategorija}' WHERE ID_rashod = {r.ID_rashod}";

            int redovi = DB.ExecuteCommand(sql);

            DB.CloseConnection();

            return redovi > 0;
        }
    }
}