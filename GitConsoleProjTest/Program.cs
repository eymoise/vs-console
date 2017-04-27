using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitConsoleProjTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Git!");

            Dice dice = new Dice();

            Console.WriteLine($"Let's roll the dice. Result is {dice.Roll()}");

            Console.ReadLine();
        }
    }
}
