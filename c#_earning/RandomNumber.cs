using System;
using System.Collections.Generic;
using System.Text;

namespace c__RandomNumber
{
     class RandomNumber
    {
        static void Main(String[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101); // Generates a random number between 1 and 100
            Console.WriteLine("Random number between 1 and 100: " + randomNumber);
            double randomDouble = random.NextDouble(); // Generates a random double between 0.0 and 1.0
            Console.WriteLine("Random double between 0.0 and 1.0: " + randomDouble);
            Console.ReadKey();
        }
    }
}
