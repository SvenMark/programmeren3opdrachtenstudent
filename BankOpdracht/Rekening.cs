using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOpdracht
{
    public class Rekening
    {
        private double rekeningSaldo;
        private double rekeningRood;
        private int rekeningNummer;
        private string rekeningNaam;
        private string rekeningAdres;

        public Rekening()
        {
            
        }

        public void GeldOpnemen()
        {
            
        }

        public void GeldStorten()
        {
            
        }

        public void GeldOvermaken()
        {
            
        }

        public string ToString()
        {
            return String.Format("Naam: {0} | RekeningNr: {1} | Saldo: {2}", rekeningNaam, rekeningNummer, rekeningSaldo);
        }

    }
}
