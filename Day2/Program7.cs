using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program7
    {
        static void Main()
        {
            Console.Write("Enter a number(1-7): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Mon");
                    break;
                case "2":
                    Console.WriteLine("Tue");
                    break;
                case "3":
                    Console.WriteLine("Wed");
                    break;
                case "4":
                    Console.WriteLine("Thu");
                    break;
                case "5":
                    Console.WriteLine("Fri");
                    break;
                case "6":
                    Console.WriteLine("Sat");
                    break;
                case "7":
                    Console.WriteLine("Sun");
                    break;
                default:
                    Console.WriteLine("Wrong value!");
                    break;
            }
        }
    }
}
