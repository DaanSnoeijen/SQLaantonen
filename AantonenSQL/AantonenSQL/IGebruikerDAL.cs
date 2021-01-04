using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AantonenSQL
{
    public interface IGebruikerDAL
    {
        GebruikerDTO GetGebruiker(string Gebruikersnaam, string Wachtwoord);
    }
}
