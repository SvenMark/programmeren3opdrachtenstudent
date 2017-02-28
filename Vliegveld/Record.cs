using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Vliegveld
{
    public class Record
    {
        public string VluchtNr { get; set; }
        public string Maatschappij { get; set; }
        public string Vlucht { get; set; }
        public string Bestemming { get; set; }
        public string Vertrek { get; set; }
        public string Status { get; set; }
        public string Optijd { get; }
        public string Model { get; set; }
        public string Callsign { get; set; }
        public string Owner { get; set; }

        public Record(string vluchtnr, string maatschappij, string vlucht, string bestemming, string vertrek, string status, string optijd, string model, string callsign, string owner)
        {
            VluchtNr = vluchtnr;
            Maatschappij = maatschappij;
            Vlucht = vlucht;
            Bestemming = bestemming;
            Vertrek = vertrek;
            Status = status;
            Optijd = optijd;
            Model = model;
            Callsign = callsign;
            Owner = owner;
        }
    }
}