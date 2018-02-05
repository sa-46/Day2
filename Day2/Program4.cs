using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program4
    {
        static void Main()
        {
            int a = 5;
            int b = 3;

            Console.WriteLine(a == b); //False
            bool c = (a != b);
            Console.WriteLine(c); //True

            Console.WriteLine(a < a); //False

            Console.WriteLine((b > 1) && (a > 10)); //False

            Console.WriteLine((b > 1) & (a > 10)); //False

            Console.WriteLine(Math.Max(a, b)); //5
            Console.WriteLine(Math.Min(a, b)); //3

            Console.WriteLine(Math.Ceiling(2.3)); //3
            Console.WriteLine(Math.Round(2.35671)); //2 
            Console.WriteLine(Math.Round(2.35671, 2)); //2.36

        }
    }
}
