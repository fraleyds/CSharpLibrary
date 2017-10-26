using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Netflix
    {
        // Properties
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        // Methods
        public void GetSuggestion()
        {
            if (this.Rating < 3 && this.Rating >=1)
            {
                Console.WriteLine("It's a tremendous waste of your time. Only watch if you're drinking lots of alcohol with friends.");
            }
            else if (this.Rating >= 3 && this.Rating < 4)
            {
                Console.WriteLine("If you don't have anything else on your plate, maybe go watch it. It ain't bad.");
            }
            else if (this.Rating >= 4 && this.Rating <= 5)
            {
                Console.WriteLine("Duuuuuude. Go watch it.");
            }
            else
            {
                Console.WriteLine("That's not an input I understand.");
            }
        }


    }
}
