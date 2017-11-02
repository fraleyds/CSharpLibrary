using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Player : Character
    {
        //Constructor
        public Player(string name)
        {
            this.Name = name;
            this.IsAlive = true;
            this.Health = 100;
            this.Level = 1;
            this.Marksmanship = 0;
            this.Piloting = 0;
            this.Luck = 10;
            this.Wealth = 5000;
            this.Defense = 5;
        }

        //Properties
        public double Wealth { get; set; }
    }
}
