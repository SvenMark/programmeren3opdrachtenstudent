using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgje
{
    class Hangman
    {
        private string word;
        private string result;
        private int maxTurns;
        private int turn;
        private List<char> goodpart = new List<char>();
        private List<char> guessed = new List<char>();

        public Hangman(string word)
        {
            this.word = word;
            for (int i = 0; i <= word.Length - 1; i++) { goodpart.Add('-'); }
        }

        public Hangman(string word, int maxTurns)
        {
            this.word = word;
            this.maxTurns = maxTurns;
            for (int i = 0; i <= word.Length - 1; i++) { goodpart.Add('-'); }

        }

        public string GetWordForDisplay()
        {
            result = "";
            foreach (char g in goodpart)
            {
                result += g;
            }
            return result;
        }

        public int TurnNumber()
        {
            return turn;
        }

        public bool Guess(char guess)
        {
            guessed.Add(guess);
            bool hit = false;
            int i = 0;
            while ((i = word.IndexOf(guess, i)) != -1)
            {
                hit = true;
                goodpart[i] = guess;
                i++;
            }
            if (hit)
            {
                return true;
            }
            turn += 1;
            return false;
        }

        public bool HasGuessedLetterBefore(char c)
        {
            foreach (char g in guessed)
            {
                if (c == g)
                {
                    turn += 1;
                    return true;
                }
            }
            return false;
        }

        public bool Won()
        {
            if (result == word)
            {
                return true;
            }
            return false;
        }

        public bool Lose()
        {
            if (turn == maxTurns)
            {
                return true;
            }
            return false;
        }
    }
}
