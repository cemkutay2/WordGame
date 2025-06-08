using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame
{
    public abstract class Game
    {
        public int Score { get; protected set; }
        public string CurrentWord { get; protected set; }
        public string ScrambledWord { get; protected set; }

        public abstract void GenerateNewWord();
        public abstract bool CheckGuess(string guess);
        public abstract void SubstractScoreByOne();
    }
}
