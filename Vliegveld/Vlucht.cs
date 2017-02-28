using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vliegveld
{
    class Vlucht
    {
        public Vliegtuig Vliegtuig { get; set; }
        public Luchthaven Van { get; set; }
        public Luchthaven Naar { get; set; }
        public DateTime Vertrek { get; set; }
        public string Status { get; set; }
        public List<Uitvoerder> Uitvoerders { get; set; }

        public Vlucht(Vliegtuig vliegtuig, Luchthaven van, Luchthaven naar, DateTime vertrek, string status)
        {
            //Status = records[0].Status;
        }

        public void AddUitvoerder(Maatschappij maatschappij, string vluchtNr)
        {
            throw new NotImplementedException();
        }

        public string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
