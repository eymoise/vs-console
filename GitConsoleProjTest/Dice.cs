using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitConsoleProjTest
{
    // Adding a class to represent two dice.
    // This is in order to understand how to use branches in Git.
    class Dice
    {
        public Dice()
        {
            random = new Random();
        }

        public Dice(int seed)
        {
            random = new Random(seed);
        }

        private Random random;

        public int Roll()
        {
            return random.Next(1, 6) + random.Next(1, 6);
        }
    }
}
