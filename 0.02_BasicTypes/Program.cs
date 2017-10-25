using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            byte myByte = 15; // range: 0 - 255

            int number1 = 15;

            float myFloat = 3.14f;

            double myDouble = 2.54;

            decimal myDecimal = 3.14159M;

            char myLetter = 'A';

            string myName = "David";

            bool myTruth = true;

            //Console.WriteLine(myLetter);
            //Console.ReadLine();

            // Declaration
            // <type> <variableName> = <optional initializer>;
            int age;
            string country;

            // Initialization
            age = 23;
            Console.WriteLine(age);
            age = 83;
            Console.WriteLine(age);
            Console.ReadLine();
        }
    }
}