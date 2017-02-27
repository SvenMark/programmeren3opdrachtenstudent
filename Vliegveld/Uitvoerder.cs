using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vliegveld
{
    class Uitvoerder
    {
        public string VluchtNr { get; set; }
        public Maatschappij Maatschappij { get; set; }
        public Vlucht Vlucht { get; set; }

        public Uitvoerder(string vluchtNr, Maatschappij maatschappij, Vlucht vlucht)
        {
            throw new NotImplementedException();
        }

        public string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
