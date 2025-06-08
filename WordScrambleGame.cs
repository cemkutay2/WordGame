using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame
{
    public class WordScrambleGame : Game
    {
        private WordBank wordBank;
        private Random random;

        public WordScrambleGame(string wordFilePath)
        {
            wordBank = new WordBank(wordFilePath);
            random = new Random();
        }

        public override void GenerateNewWord()
        {
            CurrentWord = wordBank.GetRandomWord();
            ScrambledWord = new string(CurrentWord.OrderBy(x => random.Next()).ToArray());
        }

        public override bool CheckGuess(string guess)
        {
            if (guess.Trim().ToLower() == CurrentWord.ToLower())
            {
                Score++;
                return true;
            }
            return false;
        }
        public override void SubstractScoreByOne()
        {
            Score--;
        }
    }

}
