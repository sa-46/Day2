using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program5
    {
        static void Main()
        {
            Console.Write("Enter a number(1-7): ");
            string input = Console.ReadLine();

            if (input == "1") Console.WriteLine("Mon");
            if (input == "2") Console.WriteLine("Tue");
            if (input == "3") Console.WriteLine("Wed");
            if (input == "4") Console.WriteLine("Thu");
            if (input == "5") Console.WriteLine("Fri");
            if (input == "6") Console.WriteLine("Sat");
            if (input == "7") Console.WriteLine("Sun");
        }
    }
}
