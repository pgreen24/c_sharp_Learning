using System;
using System.Collections.Generic;
using System.Text;

namespace c__typecasting
{
  class typecasting
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = 20.5;
            double c = a + b; // Implicit typecasting
            Console.WriteLine("The value of c is: " + c);
            double d = 30.7;
            int e = (int)d; // Explicit typecasting
            Console.WriteLine("The value of e is: " + e);
            double f = 40.9;
            int g = Convert.ToInt32(f); // Using Convert class for typecasting
            Console.WriteLine("The value of g is: " + g);
            Console.WriteLine("The type of g is: " + g.GetType());
            Console.WriteLine("The type of f is: " + f.GetType());
            int h = 50;
            double i = Convert.ToDouble(h); // Implicit typecasting
            Console.WriteLine("The value of i is: " + i);
            Console.WriteLine("The type of i is: " + i.GetType());

            int j = 60;
            String k = Convert.ToString(j); // Using ToString() method for typecasting
            Console.WriteLine("The value of k is: " + k);
            Console.WriteLine("The type of k is: " + k.GetType());

            String l = "$";
            char m = Convert.ToChar(l); // Using Convert class for typecasting
            Console.WriteLine("The value of m is: " + m);
            Console.WriteLine("The type of m is: " + m.GetType());

            String n = "true";
            bool o = Convert.ToBoolean(n); // Using Convert class for typecasting
            Console.WriteLine("The value of o is: " + o);
            Console.WriteLine("The type of o is: " + o.GetType());

            Console.ReadKey();
        }
    }
}
