using System;
using System.Collections.Generic;
using System.Text;

namespace c__mathclass
{
     class mathclass
    {
        static void Main(String[] args)
        {
            int a = 10;
            int b = 20;
            double c = Math.Sqrt(b); // Square root
            Console.WriteLine("The square root of b is: " + c);
            double d = Math.Pow(a, 2); // Power
            Console.WriteLine("The value of a raised to the power of 2 is: " + d);
            double e = Math.Abs(-30.5); // Absolute value
            Console.WriteLine("The absolute value of -30.5 is: " + e);
            double f = Math.Round(20.3); // Rounding
            Console.WriteLine("The rounded value of 20.3 is: " + f);
            double g = Math.Ceiling(20.1); // Ceiling
            Console.WriteLine("The ceiling value of 20.1 is: " + g);
            double h = Math.Floor(20.9); // Floor
            Console.WriteLine("The floor value of 20.9 is: " + h);
            double i = Math.Max(a, b); // Maximum
            Console.WriteLine("The maximum value between a and b is: " + i);
            double j = Math.Min(a, b); // Minimum
            Console.WriteLine("The minimum value between a and b is: " + j);
            Console.ReadKey();
        }
    }
}
