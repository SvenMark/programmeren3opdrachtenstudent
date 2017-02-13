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
        private string naam;
        private int accountNumber;

        public Bank(string naam)
        {
            this.naam = naam;
        }

        public string Naam
        {
            get { return naam; }
        }

        public int OpenRekening(string firstName, string lastName, string houseNumber, string postalCode)
        {
            return accountNumber;
        }

        public int OpenRekening(string firstName, string lastName, string houseNumber, string postalCode, int startSaldo)
        {
            return accountNumber;
        }

        public int OpenRekening(string firstName, string lastName, string houseNumber, string postalCode, int startSaldo, int salary)
        {
            return accountNumber;
        }
    }
}
