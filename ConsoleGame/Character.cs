using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public abstract class Character
    {
        //Properties
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public double Marksmanship { get; set; }
        public double Piloting { get; set; }
        public double Luck { get; set; }
        public double Defense { get; set; }
    }
}
