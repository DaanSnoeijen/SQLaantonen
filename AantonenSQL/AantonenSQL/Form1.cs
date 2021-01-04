using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AantonenSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetAccount_Click(object sender, EventArgs e)
        {
            GebruikerViewModel gebruiker = new GebruikerViewModel(
                Program.gebruikerContainer.GetGebruiker(Gebruikersnaam.Text, Wachtwoord.Text).name, 
                Program.gebruikerContainer.GetGebruiker(Gebruikersnaam.Text, Wachtwoord.Text).age);

            if (gebruiker.name != "" && gebruiker.age != 0)
            {
                Naam.Text = gebruiker.name;
                Leeftijd.Text = gebruiker.age.ToString();
            }
            else
            {
                MessageBox.Show("Gebruikersnaam of wachtwoord incorrect");
            }
        }
    }
}
