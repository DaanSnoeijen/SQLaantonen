using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AantonenSQL
{
    class GebruikerDAL : IGebruikerDAL
    {
        public GebruikerDTO GetGebruiker(string Gebruikersnaam, string Wachtwoord)
        {
            string connetionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=DBSQL;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand cmd;
            SqlDataReader rdr;

            string checkUserAccount =
                @"SELECT Gebruiker.Name, Gebruiker.Age
                  FROM Account
                  INNER JOIN Gebruiker ON Account.GebruikerID=Gebruiker.ID
                  WHERE Gebruikersnaam = @Gebruikersnaam AND Wachtwoord = @Wachtwoord";

            string naam = "";
            int leeftijd = 0;

            try
            {
                connection.Open();
                cmd = new SqlCommand(checkUserAccount, connection);

                cmd.Parameters.AddWithValue("@Gebruikersnaam", Gebruikersnaam);
                cmd.Parameters.AddWithValue("@Wachtwoord", Wachtwoord);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    naam = rdr.GetString(0);
                    leeftijd = rdr.GetInt32(1);
                }
                GebruikerDTO gebruiker = new GebruikerDTO(naam, leeftijd);

                connection.Close();
                rdr.Close();
                cmd.Dispose();

                return gebruiker;
            }
            catch
            {
                GebruikerDTO gebruiker = new GebruikerDTO(naam, leeftijd);

                return gebruiker;
            }
        }
    }
}
