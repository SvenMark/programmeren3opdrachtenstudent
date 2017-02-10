using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ing = new Bank("ing");
            int rekeningNrJoris = ing.OpenRekening("Joris", "lops", "6a", "8944AM");
            int rekeningNrDick = ing.OpenRekening("Dick", "bruin", "20", "2334WW", 1000, 500);

            Rekening ingJoris = ing.ZoekRekening(rekeningNrJoris);
            if (!ingJoris.GeldStorten(200))
            {
                Console.WriteLine("storten ongeldig");
            }
            if (!ingJoris.GeldOpnemen(50))
            {
                Console.WriteLine("geld openmen ongeldig");
            }
            if (!ingJoris.GeldStorten(30))
            {
                Console.WriteLine("geld openmen ongeldig");
            }

            Rekening ingDick = ing.ZoekRekening(rekeningNrDick);
            if (!ingJoris.GeldStorten(200))
            {
                Console.WriteLine("storten ongeldig");
            }
            if (!ingJoris.GeldOpnemen(5000))
            {
                Console.WriteLine("geld openmen ongeldig");
            }

            //geld overmaken
            if (!ingJoris.GeldOvermaken(ingDick, 100))
            {
                Console.WriteLine("geld overmaken ongeldig");
            }

            //afdrukken van rekening ing (joris, dick)
            Console.WriteLine(ing.ToString());

            Rekening dickRekening = ing.VerwijderRekening(rekeningNrDick);
            //rekening gevens van dick afdrukken
            Console.WriteLine(dickRekening.ToString());

            //afdrukken van rekeningen ing (joris)
            Console.WriteLine(ing.ToString());


        }
    }
}
