using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix strangerThings = new Netflix();
            Netflix parksAndRecreation = new Netflix();
            Netflix theOffice = new Netflix();

            strangerThings.Name = "Stranger Things";
            strangerThings.Genre = "Horror(?)";
            strangerThings.Rating = 3.0;

            parksAndRecreation.Name = "Parks & Recreation";
            parksAndRecreation.Genre = "Comedy";
            parksAndRecreation.Rating = 5.0;

            theOffice.Name = "The Office";
            theOffice.Genre = "Comedy";
            theOffice.Rating = 3.8;

            //strangerThings.GetSuggestion();
            //parksAndRecreation.GetSuggestion();
            //theOffice.GetSuggestion();

            // Creating a list of Objects
            List<Netflix> favoriteShows = new List<Netflix>();

            favoriteShows.Add(theOffice);
            favoriteShows.Add(strangerThings);
            favoriteShows.Add(parksAndRecreation);

            foreach (Netflix show in favoriteShows)
            {
                Console.WriteLine(show.Name);
                Console.WriteLine(show.Genre);
                Console.WriteLine(show.Rating);
            }


        }
    }
}
