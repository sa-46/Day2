using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program8
    {
        public static Main()
        {
            Console.Write("Enter your result: ");
            string input = Console.ReadLine();
            double result = Double.Parse(input);

            int grade = -1;

            if ( (0<=result) && (result <= 40))
            {
                grade = 1;
            } else if ((40 < result) && (result <= 70))
            {
                grade = 2;
            } else if ((70 < result) && (result <= 100))
            {
                grade = 3;
            }

            /* //conditions should be mutually exclusive if possible.
            if ((70 < result) && (result <= 100))
            {
                int grade = 3;
            }
            else if ((40 < result) && (result <= 70))
            {
                int grade = 2;
            }
            else if ((0 <= result) && (result <= 40))
            {
                int grade = 1;
            }*/

            if (grade != -1)
            {
                Console.WriteLine("Grade = {0} ", grade);
            } else
            {
                Console.WriteLine("You entered an invalid result.");
            }
        }
    }
}
