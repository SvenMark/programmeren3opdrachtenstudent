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
            if (result.Length < 6)
            {
                result = words[0];
            }
            words.Remove(result);
            return result;
        }

        public void RemoveWord(string remove)
        {
            foreach (string word in words)
            {
                if (word == remove)
                {
                    words.Remove(remove);
                }
            }
        }
    }
}
