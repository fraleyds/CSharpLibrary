using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._01_Euler1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find sum of all multiples of 3 or 5 below 1000
            int number = 1;
            int sum = 0;

            while (number < 1000)
            {
                if (number % 3 == 0 || number % 5 == 0)
                {
                    sum = sum + number;
                }
                number++;
            }
            Console.WriteLine(sum);
        }
    }
}
