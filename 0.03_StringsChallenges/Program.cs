using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_StringsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // BRONZE
            //Currency
            double cash = 563.3265;
            Console.WriteLine("{0:C}", cash);

            //Percentage
            double exchangeRate = 0.23;
            Console.WriteLine("{0:#0.##%}", exchangeRate);
            Console.WriteLine("{0:P}", exchangeRate);

            //Phone Number
            double phoneNumber = 8234567890;
            Console.WriteLine("{0:(###) ### - ####}", phoneNumber);

            // SILVER
            string potentialEmployerName = "Mr. Bacon";
            string date = DateTime.Today.ToShortDateString();

            Console.WriteLine($"Dear {potentialEmployerName}");
            Console.WriteLine($"Today is {date}. I'm enjoying class, and C# is nifty.");
            Console.WriteLine("I'd like to get a job as a developer after I finish this course.");
            Console.WriteLine("Please hire me.");

            // GOLD
            string userNameLow = "fraleyds";
            string userNameUp = "FRALEYDS";

            bool comparisonSensitive = userNameLow.Equals(userNameUp, StringComparison.Ordinal);
            bool comparisonInsensitive = userNameLow.Equals(userNameUp, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine($"The statement: {userNameLow} == {userNameUp} is {comparisonSensitive}.");
            Console.WriteLine($"The statement: {userNameLow} == {userNameUp} is {comparisonInsensitive}.");
        }
    }
}
