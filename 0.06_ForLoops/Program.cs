using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i+=2)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i <= 10; i++)
            {
                if (i < 10)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("It hit 10!");
                }
            }
        }
    }
}
