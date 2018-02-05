using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program2
    {
        static void Main()
        {
            int a = 5;
            int b = 3;

            Console.WriteLine(+a); //5
            Console.WriteLine(-a); //-5

            a = 5;
            int c = ++a; //increment a and assign the result into c
            Console.WriteLine(c); //6
            Console.WriteLine(a); //6

            a = 5;
            int d = a++; //assign a to d and afterwards increment a
            Console.WriteLine(d); //5
            Console.WriteLine(a); //6

            int e = a++ * ++b / b++; //don't do this
        }
    }
}
