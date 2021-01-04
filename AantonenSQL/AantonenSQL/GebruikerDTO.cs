using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AantonenSQL
{
    public class GebruikerDTO
    {
        public string name { get; private set; }
        public int age { get; private set; }

        public GebruikerDTO(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
    }
}
