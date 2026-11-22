using System;
using System.Collections.Generic;
using System.Text;

namespace c__arithmaticOperators
{
     class arithmeticOperators
    {
        static void Main(String[] args)
        {
            int a = 10;
            int b = 20;
            int c = a + b; // Addition
            Console.WriteLine("The value of c is: " + c);
            int d = a - b; // Subtraction
            Console.WriteLine("The value of d is: " + d);
            int e = a * b; // Multiplication
            Console.WriteLine("The value of e is: " + e);
            double f = (double)a / b; // Division
            Console.WriteLine("The value of f is: " + f);
            int g = a % b; // Modulus
            Console.WriteLine("The value of g is: " + g);

            int friends = 10;
            friends += 5; // friends = friends + 5
            // friends++;

            // friends = friends - 5;
            // friends--;

            // friends = friends * 2;
            // friends *= 2;

            // friends = friends / 2;
            // friends /= 2;

            // friends = friends % 3;
            // friends %= 3;


            Console.WriteLine("The value of friends is: " + friends);

            Console.ReadKey();
        }
    }
}
