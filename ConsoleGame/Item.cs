using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    abstract class Item
    {
        //Properties
        public string Name { get; set; }
        public double Value { get; set; }
        public double Attack { get; set; }
        public double Charge { get; set; }
    }
}
