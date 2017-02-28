using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vliegveld
{
    class Maatschappij
    {
        public string Naam { get; set; }
        public string Afkorting { get; set; }

        public Maatschappij(string naam, string afkorting)
        {
            Naam = naam;
            Afkorting = afkorting;
        }

        public string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
