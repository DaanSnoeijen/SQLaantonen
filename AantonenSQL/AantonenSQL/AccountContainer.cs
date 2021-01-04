using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AantonenSQL
{
    class AccountContainer
    {
        public List<Account> accounts = new List<Account>();

        public void AddAccount(string gebruikersnaam, string wachtwoord)
        {
            Account account = new Account(gebruikersnaam, wachtwoord);

            accounts.Add(account);
        }
    }
}
