using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AantonenSQL
{
    class Gebruiker
    {
        public string name { get; private set; }
        public int age { get; private set; }

        public Gebruiker(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
    }
}
