using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_LoopsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //BRONZE
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////SILVER
            //int n = 0;
            //while (n <= 100)
            //{
            //    Console.WriteLine(n);
            //    n+=5;
            //}

            //GOLD
            for (int loopInt = 1; loopInt <= 100; loopInt++)
            {
                if (loopInt % 3 == 0 && loopInt % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (loopInt % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (loopInt % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(loopInt);
                }
            }
        }
    }
}
