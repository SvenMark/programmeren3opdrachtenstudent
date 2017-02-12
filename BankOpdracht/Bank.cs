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
        public string Naam;
        private int accountNumber;

        public Bank(string Naam)
        {
            this.Naam = Naam;
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
