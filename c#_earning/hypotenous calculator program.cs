using System;
using System.Collections.Generic;
using System.Text;

namespace c__hypotenous_calculator_program
{
     class hypotenous_calculator_program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the length of the first side:");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side:");
            double side2 = Convert.ToDouble(Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
            Console.WriteLine("The length of the hypotenuse is: " + hypotenuse);
            Console.ReadKey();
        }
    }
}
