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
        private List<Rekening> rekeningen = new List<Rekening>();

        public string Naam
        {
            get { return naam; }
        }

        public Bank(string naam)
        {
            this.naam = naam;
        }

        public int OpenRekening(string firstName, string lastName, string houseNumber, string postalCode)
        {
            int idx = rekeningen.Count();
            rekeningen.Add(new Rekening(idx, firstName, lastName, houseNumber, postalCode));
            return idx;
        }

        public int OpenRekening(string firstName, string lastName, string houseNumber, string postalCode, int startSaldo)
        {
            //klant mag niet een rekening openen met een negatief saldo
            if (startSaldo < 0) return -1;
            int idx = rekeningen.Count();
            rekeningen.Add(new Rekening(idx, firstName, lastName, houseNumber, postalCode, startSaldo));
            return idx;
        }

        public int OpenRekening(string firstName, string lastName, string houseNumber, string postalCode, int startSaldo, int salaris)
        {
            //klant mag niet een rekening openen met een negatief saldo
            if (startSaldo < 0) return -1;
            int idx = rekeningen.Count();
            rekeningen.Add(new Rekening(idx, firstName, lastName, houseNumber, postalCode, startSaldo, salaris));
            return idx;
        }

        public Rekening ZoekRekening(int rekeningNummer)
        {
            return rekeningen[rekeningNummer];

        }

        public Rekening VerwijderRekening(int rekeningNummer)
        {
            //andere opties??
            //rekeningen.Remove() kan niet want dan schuiven de rekeningnummers op en komen de indexes niet meer overeen.
            Rekening rekening = rekeningen[rekeningNummer];
            rekeningen[rekeningNummer] = null;
            return rekening;
        }

        public decimal RenteUitkeren(decimal percentage)
        {
            decimal totaalUitgekeerd = 0;
            foreach (Rekening r in rekeningen)
            {
                decimal rente = 0;
                if (r.Saldo > 0)
                {
                    rente = r.Saldo * (percentage/100);
                    totaalUitgekeerd += rente;
                    r.GeldStorten(rente);
                }
            }
            return totaalUitgekeerd;
        }

        public string ToString()
        {
            string result = "Naam van bank: " + naam + "\n";
            foreach (Rekening r in rekeningen)
            {
                //als een object-instantie wordt verwijdert word hij naar null gezet en die geeft hier een error.
                if (r != null)
                {
                    result += r.ToString() + "\n";
                }
            }
            return result;



            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Naam van bank: {0}", naam);
            //Console.WriteLine("---------------------------");
            //foreach (Rekening r in rekeningen)
            //{
            //    ToString()
            //}
        }
    }
}