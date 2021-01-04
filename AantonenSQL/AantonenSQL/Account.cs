using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AantonenSQL
{
    class Account
    {
        public string gebruikersnaam { get; private set; }
        public string wachtwoord { get; private set; }

        public Account(string Gebruikersnaam, string Wachtwoord)
        {
            gebruikersnaam = Gebruikersnaam;
            wachtwoord = Wachtwoord;
        }
    }
}
