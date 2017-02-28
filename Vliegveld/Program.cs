using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vliegveld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            List<Record> records = new List<Record>();
            List<Vlucht> vluchten = new List<Vlucht>();
            List<Vliegtuig> vliegtuigen = new List<Vliegtuig>();
            List<Uitvoerder> uitvoerders = new List<Uitvoerder>();
            List<Maatschappij> maatschappijen = new List<Maatschappij>();
            List<Luchthaven> luchthavens = new List<Luchthaven>();
            string vluchtgegevens = Path.Combine(Environment.CurrentDirectory, "bestanden\\vluchtgegevens.txt");
            StreamReader reader = new StreamReader(vluchtgegevens);

            //scraper van txt bestand, zet alle waarden in records
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("=") || line.StartsWith("VluchtNr")) continue;
                data = line.Split(',').ToList<string>();
                for (int i = 0; i < data.Count; i++)
                {
                    data[i] = data[i].Replace("\t", string.Empty).TrimStart(' ').TrimEnd(' ');
                }
                data.RemoveAt(4);
                records.Add(new Record(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9]));
            }

            reader.Close();

            //objecten maken
            int count = 0;
            int van = 0;
            int naar = 1;
            foreach (Record record in records)
            {
                //Vliegtuig.cs
                vliegtuigen.Add(new Vliegtuig(record.Callsign, record.Model, record.Owner));

                //Maatschappij.cs
                maatschappijen.Add(new Maatschappij(record.Maatschappij.Split(')')[1].Trim(), record.Maatschappij.Split('(', ')')[1]));

                //Luchthaven.cs
                luchthavens.Add(new Luchthaven(record.Vlucht.Split(')')[1].Trim(), record.Vlucht.Split('(', ')')[1]));
                luchthavens.Add(new Luchthaven(record.Bestemming.Split(')')[1].Trim(), record.Bestemming.Split('(', ')')[1]));

                //Vlucht.cs
                vluchten.Add(new Vlucht(vliegtuigen[count], luchthavens[van], luchthavens[naar], Convert.ToDateTime(record.Vertrek), record.Status));

                //Uitvoerder.cs
                uitvoerders.Add(new Uitvoerder(record.VluchtNr, maatschappijen[count], vluchten[count]));


                //++
                count++;
                van += 2;
                naar += 2;
            }






            //debug
            //foreach (string item in data)
            //{
            //    //Console.WriteLine(item);
            //}

            //Console.WriteLine(records[0].Maatschappij);
            //Console.WriteLine(maatschappijen[0].Naam);
            //Console.WriteLine(maatschappijen[0].Afkorting);
            //Console.WriteLine((luchthavens[0].Afkorting));
            //Console.WriteLine(luchthavens[0].Naam);
            //Console.WriteLine(vluchten[0].ToString());
            //Console.WriteLine((vluchten[2].ToString()));

            //foreach (Luchthaven luchthaven in luchthavens)
            //{
            //    Console.WriteLine(luchthaven.ToString());
            //}

            //foreach (Uitvoerder uitvoerder in uitvoerders)
            //{
            //    Console.WriteLine(uitvoerder.ToString());
            //}

            //probleem
            //vluchten[0].AddUitvoerder(maatschappijen[0], "HV 5753");

            //print
            Console.WriteLine("Schema \t\t\t Herkomst \t\t Vluchtnr. \t\t Maatschappij \t\t Opmerkingen");
            for (int i = 0; i < vluchten.Count; i++)
            {
                Console.WriteLine(vluchten[i].Vertrek + "\t" + vluchten[i].Van.Naam + "\t\t" + uitvoerders[i].VluchtNr + "\t" + uitvoerders[i].Maatschappij.Naam + "\t\t\t" + vluchten[i].Status);
            }
        }
    }
}