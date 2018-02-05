using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program6
    {
        static void Main()
        {
            Console.Write("Enter a number(1-7): ");
            string input = Console.ReadLine();

            if (input == "1") Console.WriteLine("Mon");
            else if (input == "2") Console.WriteLine("Tue");
            else if (input == "3") Console.WriteLine("Wed");
            else if (input == "4") Console.WriteLine("Thu");
            else if (input == "5") Console.WriteLine("Fri");
            else if (input == "6") Console.WriteLine("Sat");
            else if (input == "7") Console.WriteLine("Sun");
        }
    }
}
