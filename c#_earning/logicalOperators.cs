using System;
using System.Collections.Generic;
using System.Text;

namespace c__LogicalOperators
{
     class logicalOperators
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("The number is between 0 and 100.");
            }
            else if (number <= -50 || number >= 100)
            {
                Console.WriteLine("The number is not between -50 and 100.");
            }
            Console.ReadKey();
        }
    }
}
