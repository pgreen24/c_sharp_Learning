using System;
using System.Collections.Generic;
using System.Text;

namespace c__variable
{
    class variable
    {
        static void Main (string[] args)
        {
            int x=24; int y=34; int z =x+ y;
            int age =x+y;
            double height = 250.6;
            bool alive = false;
            char symbol = '@';
            String name = "Lima";
            String UserName = symbol + name;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine ("hello "+ name);
            Console.WriteLine("YOUR AGE IS " +  age);
            Console.WriteLine("Your height is " +  height +"cm");
            Console.WriteLine("are you Alive "+ alive );
            Console.WriteLine("your user name is "+UserName);
            

            Console.ReadKey();
        }
    }
}
