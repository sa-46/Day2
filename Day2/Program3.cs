using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program3
    {
        static void Main()
        {
            int a = 5;
            int b = 3;

            Console.WriteLine(10 - 5 / a); //9
            Console.WriteLine(10 - 5 / -a); //11

            Console.WriteLine(10 - (5 / a)); //9
            Console.WriteLine((10 - 5) / a); //1
        }
    }
}
