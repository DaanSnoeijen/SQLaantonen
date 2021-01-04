using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AantonenSQL
{
    static class Program
    {
        static IGebruikerDAL gebruikerDAL = new GebruikerDAL();

        public static AccountContainer accountContainer = new AccountContainer();
        public static GebruikerContainer gebruikerContainer = new GebruikerContainer(gebruikerDAL);

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
