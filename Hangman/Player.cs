using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Player
    {
        public string userName;
        public int score;
        public List<char> guessedLetters = new List<char>();

        public Player(string name)
        {
            this.userName = name;
        }
    }
}
