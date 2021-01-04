using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AantonenSQL
{
    class GebruikerViewModel
    {
        public string name { get; private set; }
        public int age { get; private set; }

        public GebruikerViewModel(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
    }
}
