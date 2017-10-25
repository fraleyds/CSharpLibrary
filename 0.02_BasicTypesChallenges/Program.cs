using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // BRONZE CHALLENGE
            int myInt1;
            int myInt2 = 88;

            string myString1;
            string myString2 = "Sup.";

            bool myBool1;
            bool myBool2 = false;

            float myFloat1;
            float myFloat2 = 4.52f;

            double myDouble1;
            double myDouble2 = 44.44;

            decimal myDecimal1;
            decimal myDecimal2 = 435.66M;

            Console.WriteLine(myInt2);
            Console.WriteLine(myString2);
            Console.WriteLine(myBool2);
            Console.WriteLine(myFloat2);
            Console.WriteLine(myDouble2);
            Console.WriteLine(myDecimal2);
            // Console.ReadLine();

            // SILVER CHALLENGE
            string concat1 = "I've got ";
            string concat2 = "a lovely bunch of coconuts.";

            string singingStrings = concat1 + concat2;

            Console.WriteLine(singingStrings);
            // Console.ReadLine();

            // GOLD CHALLENGE
            string birthYearString = "1994";
            int birthYearInt = Int32.Parse(birthYearString);
            var yearMessage = string.Format("I was born in {0}.", birthYearInt);
            Console.WriteLine(yearMessage);
            Console.ReadLine();

        }
    }
}
