using System;
using System.Collections.Generic;
using System.Text;

namespace c__whileLoop
{
    class whileLoop
    {
        static void Main(String[] args)
        {
           Console.Write("Enter your name: ");
            string name = Console.ReadLine();
                while(name == "")
            {
                Console.WriteLine("Name cannot be empty. Please enter your name: ");
                name = Console.ReadLine();
            }
                Console.WriteLine("Hello " + name);
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine("Hello " + name);
            //    i++;
            //}
            Console.ReadKey();
        }

    }
}
