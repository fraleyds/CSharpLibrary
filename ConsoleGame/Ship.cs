using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Ship : Item
    {
        //Properties
        public double Hull { get; set; }
        public double Defense { get; set; }
        public double Evasion { get; set; }
    }
}
