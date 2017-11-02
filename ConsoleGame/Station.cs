using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Station : Location
    {
        //Constructor
        public Station(string name, bool hasStore, int prosperity)
        {
            this.Name = name;
            this.HasStore = hasStore;
            this.Prosperity = prosperity;
        }

        //Properties
        public bool HasStore { get; set; }
        public int Prosperity { get; set; }
    }
}
