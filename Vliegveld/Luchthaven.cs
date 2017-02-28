using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vliegveld
{
    class Luchthaven
    {
        public string Naam { get; set; }
        public string Afkorting { get; set; }

        public Luchthaven(string naam, string afkorting)
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
