using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBowlingGameKata
{
    public class Game
    {
        private int score;

        public void roll(int pins)
        {
            score += pins;
        }

        public int Score()
        {
            return score;
        }
    }
}
