using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Vliegveld
{
    class Vliegtuig
    {
        public string Callsign { get; set; }
        public string Model { get; set; }
        public string Fabrikant { get; set; }

        public Vliegtuig(string callsign, string model, string fabrikant)
        {
            Callsign = callsign;
            Model = model;
            Fabrikant = fabrikant;
        }

        public string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
