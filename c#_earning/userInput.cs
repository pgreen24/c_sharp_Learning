using System;
using System.Collections.Generic;
using System.Text;

namespace c__Userinput
{
     class userInput
    {
        static void Main(String[] args)
        {
            Console.WriteLine("what's your name?");
            String name = Console.ReadLine();

            Console.WriteLine("what's your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old.");


            Console.ReadKey();
        }
    }
}
