//using NUnit.Framework;
//using System;
using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace Galgje
{
    public class WordManager
    {
        private List<string> words = new List<string> { "banaan", "bijlage", "afspraak", "afrikaans", "aangedrukt", "zaaimachine", "yoghurtplant" };
        public string GetWord(int letters)
        {
            string result = "";
            foreach (string word in words)
            {
                if (word.Length == letters)
                {
                    result = word;
                }
            }
            return result;
        }
    }
}
