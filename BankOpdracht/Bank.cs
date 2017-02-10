using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOpdracht
{
    public class Bank
    {
        private string bankNaam;
        private List<Rekening> Rekeningen;
        private int index = 0;

        public Bank(string bankNaam)
        {
            this.bankNaam = bankNaam;
        }

        public void OpenRekening()
        {
            Rekening  = new Rekening();
        }

        public void VerwijderRekening()
        {
            
        }

        public void ZoekRekening()
        {
            
        }
    }
}
