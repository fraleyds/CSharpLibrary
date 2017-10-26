using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_DictionaryChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //BRONZE
            Dictionary<int, string> academyAwards = new Dictionary<int, string>()
            {
                {2000,"Gladiator"},
                {2001,"A Beautiful Mind"},
                {2002,"Chicago"},
                {2003,"The Lord of the Rings: The Return of the King"},
                {2004,"Million Dollar Baby"},
                {2005,"Crash"}
            };
            //foreach (KeyValuePair<int, string> filmPair in academyAwards)
            //{
            //    Console.WriteLine($"{filmPair.Key}, {filmPair.Value}");
            //}

            //SILVER
            Dictionary<int, string[]> nominees = new Dictionary<int, string[]>
            {
                {2000, new string[] {"Gladiator","Chocolat","Crouching Tiger, Hidden Dragon","Erin Brockovich","Traffic"}},
                {2001, new string[] {"A Beautiful Mind","Gosford Park","In the Bedroom","The Lord of the Rings: The Fellowship of the Ring","Moulin Rouge!"}},
                {2002, new string[] {"Chicago","Gangs of New York","The Hours","The Lord of the Rings: The Two Towers","The Pianist"} },
                {2003, new string[] {"The Lord of the Rings: The Return of the King","Lost in Translation","Master and Commander: The Far Side of the World","Mystic River","Seabiscuit"} },
                {2004, new string[] {"Million Dollar Baby","The Aviator","Finding Neverland","Ray","Sideways"} },
                {2005, new string[] {"Crash","Brokeback Mountain","Capote","Good Night, and Good Luck","Munich"} }
            };
            //foreach (KeyValuePair<int, string[]> moviePair in nominees)
            //{
            //    Console.WriteLine($"In {moviePair.Key}, the Best Picture nominees were {moviePair.Value[0]}, " +
            //        $"{moviePair.Value[1]}, {moviePair.Value[2]}, {moviePair.Value[3]}, and {moviePair.Value[4]}.");
            //}

            //GOLD
            // Winner lookup by year
            Console.WriteLine("Please type a year in the space below to show the movie that won:");
            string onePrompt = Console.ReadLine();
            int promptYear1 = Convert.ToInt32(onePrompt);
            foreach (KeyValuePair<int, string> findableMovie in academyAwards)
            {
                if (findableMovie.Key == promptYear1)
                {
                    Console.WriteLine($"The winner of best picture in {findableMovie.Key} was {findableMovie.Value}");
                }
            }
            Console.ReadLine();
            Console.Clear();

            // Nominee lookup by year
            Console.WriteLine("Please type a year to show the movies that were up for an award that year:");
            string twoPrompt = Console.ReadLine();
            int promptYear2 = Convert.ToInt32(twoPrompt);
            foreach (KeyValuePair<int, string[]> nomineeGroup in nominees)
            {
                if (nomineeGroup.Key == promptYear2)
                {
                    Console.WriteLine($"The nominees for best picture in {nomineeGroup.Key} were {nomineeGroup.Value[0]}, {nomineeGroup.Value[1]}, {nomineeGroup.Value[2]}, {nomineeGroup.Value[3]}, and {nomineeGroup.Value[4]}");
                }
            }
        }
    }
}
