using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ConstructorChallenges
{
    class MobilePhone
    {
        //Constructor
        public MobilePhone(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }
        public MobilePhone(string make, string model, string owner)
        {
            this.Make = make;
            this.Model = model;
            this.Owner = owner;
        }

        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public string Owner { get; set; }
    }
}
