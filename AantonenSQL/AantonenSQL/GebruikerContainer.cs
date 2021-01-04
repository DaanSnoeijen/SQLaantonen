using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AantonenSQL
{
    class GebruikerContainer
    {
        public List<Gebruiker> gebruikers = new List<Gebruiker>();
        IGebruikerDAL dal;

        public GebruikerContainer(IGebruikerDAL DAL)
        {
            dal = DAL;
        }

        public Gebruiker GetGebruiker(string gebruikersnaam, string wachtwoord)
        {
            Gebruiker gebruiker = new Gebruiker(dal.GetGebruiker(gebruikersnaam, wachtwoord).name, dal.GetGebruiker(gebruikersnaam, wachtwoord).age);
            gebruikers.Add(gebruiker);

            return gebruiker;
        }
    }
}
