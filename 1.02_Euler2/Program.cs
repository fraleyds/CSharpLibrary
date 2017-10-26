using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._02_Euler2
{
    class Program
    {
        static void Main(string[] args)
        {
            int current = 2;
            int prev = 1;
            int sum = 2;
            int temp;
            while (current <= 4000000)
            {
                temp = current + prev;
                if (temp % 2 == 0)
                {
                    sum += temp;
                }
                prev = current;
                current = temp;
            }
            Console.WriteLine(sum);
        }
    }
}
