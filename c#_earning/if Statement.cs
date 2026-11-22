using System;
using System.Collections.Generic;
using System.Text;

namespace c__learning
{
     class if_Statement
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
            Console.ReadKey();
        }
    }
}
