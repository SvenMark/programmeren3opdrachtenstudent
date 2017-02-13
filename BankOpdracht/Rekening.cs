using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOpdracht
{
    public class Rekening
    {
        private int rekeningNummer;
        private decimal saldo;
        private decimal maxRood;
        private string voornaam;
        private string achternaam;
        private string huisnr;
        private string postcode;

        public int Nr
        {
            get { return rekeningNummer; }
        }

        public decimal Saldo
        {
            get { return saldo; }
        }

        public Rekening(int rekeningNummer, string voornaam, string achternaam, string huisnr, string postcode)
        {
            this.rekeningNummer = rekeningNummer;
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.huisnr = huisnr;
            this.postcode = postcode;
        }

        public Rekening(int rekeningNummer, string voornaam, string achternaam, string huisnr, string postcode, decimal startSaldo, decimal maxRood = 0)
        {
            this.rekeningNummer = rekeningNummer;
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.huisnr = huisnr;
            this.postcode = postcode;
            saldo = startSaldo;
            this.maxRood = maxRood/-2;
        }

        public bool GeldStorten(decimal bedrag)
        {
            if (bedrag <= 0) return false;
            saldo += bedrag;
            return true;
        }

        public bool GeldOpnemen(decimal bedrag)
        {
            if (bedrag <= 0) return false;
            if ((saldo - bedrag) < maxRood) return false;
            saldo -= bedrag;
            return true;
        }

        public bool GeldOvermaken(Rekening tegenRekening, decimal bedrag)
        {
            if ((saldo - bedrag) < maxRood) return false;
            saldo -= bedrag;
            tegenRekening.GeldStorten(bedrag);
            return true;
        }

        public string ToString()
        {
            return voornaam + " " + rekeningNummer + " " + saldo;
        }
    }
}
