using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program1
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            Console.WriteLine(5 * 3); //15

            int c = 5 - 3;
            Console.WriteLine(c); //2

            Console.WriteLine(a / b); //1 - integer division
            Console.WriteLine(a % b); //2 - remainder of 5 divide by 3

            double aa = 5.0;
            double bb = 3.0;

            Console.WriteLine(aa * bb); //15
            Console.WriteLine(aa - bb); //2

            Console.WriteLine(aa / bb); //1.666667

            Console.WriteLine(a / 2); // 2
            Console.WriteLine(a / 2.0); //2.5
            Console.WriteLine((double)a / 2);

            Console.WriteLine(aa % bb); //2.0

        }
    }
}
