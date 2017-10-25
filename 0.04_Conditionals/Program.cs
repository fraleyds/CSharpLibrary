using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("How are you feeling today, on a scale of 1-5?");
            //string input = Console.ReadLine();

            //if (input == "1")
            //{
            //    Console.WriteLine("Yikes. Do you need some chocolate or something?");
            //}
            //else if (input == "2")
            //{
            //    Console.WriteLine("Bummer. Hope you start feeling better.");
            //}
            //else if (input == "3")
            //{
            //    Console.WriteLine("Whateeeevs.");
            //}
            //else if (input == "4")
            //{
            //    Console.WriteLine("Nice. Stay positive and stuff.");
            //}
            //else if (input == "5")
            //{
            //    Console.WriteLine("Oh wow. Happy dude/dudette.");
            //}
            //else
            //{
            //    Console.WriteLine("That ain't a number from 1-5.");
            //}
            //Console.ReadLine();

            Console.WriteLine("Please enter how much money you have in your bank account in dollars. Don't include the dollar sign, please.");
            string accountAmount = Console.ReadLine();
            double accountAmountDouble = Convert.ToDouble(accountAmount);

            if (accountAmountDouble < 10000 && accountAmountDouble >= 0)
            {
                Console.WriteLine("Ouch.");
            }
            else if (accountAmountDouble >= 10000)
            {
                Console.WriteLine("Rad.");
            }
            else
            {
                Console.WriteLine("You entered something wrong. Get it together, dude.");
            }
            Console.ReadLine();
        }
    }
}
