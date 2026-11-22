using System;
using System.Collections.Generic;
using System.Text;

namespace c__Switch
{
  class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite day of the week?");
            String day = Console.ReadLine();

            switch (day)
                {
                case "Monday":
                    Console.WriteLine("Monday is your favorite day of the week.");
                    break;

                case "Tuesday":
                    Console.WriteLine("Tuesday is your favorite day of the week.");
                    break;

                case "Wednesday":
                    Console.WriteLine("Wednesday is your favorite day of the week.");
                    break;

                case "Thursday":
                    Console.WriteLine("Thursday is your favorite day of the week.");
                    break;

                case "Friday":
                    Console.WriteLine("Friday is your favorite day of the week.");
                    break;

                case "Saturday":
                    Console.WriteLine("Saturday is your favorite day of the week.");
                    break;

                default:
                    Console.WriteLine(day + " is not a valid day of the week.");
                    break;

            }
            Console.ReadKey();
        }
    }
}
