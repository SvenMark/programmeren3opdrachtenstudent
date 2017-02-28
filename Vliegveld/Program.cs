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

            //debug
            foreach(string item in data)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(records[0].Maatschappij);
        }
    }
}