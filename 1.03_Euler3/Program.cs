using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._03_Euler3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the largest prime factor of 600851475143
            double numero = 0;
            double findNumber = 600851475143;
            double largestPrime = 0;
            double primeCheck = 0;

            for (int i = 1; i <=findNumber/2)
            {
                if (numero % i == 0)
                {
                    numero++;
                }
            }
            Console.WriteLine(largestPrime);
        }
    }
}
