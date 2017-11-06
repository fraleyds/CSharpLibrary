using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class NPC : Character
    {
        //Constructor
        public NPC(string name, int level, int health, double marksmanship, double piloting, double luck, double defense)
        {
            this.Name = name;
            this.IsAlive = true;
            this.Level = level;
            this.Health = health;
            this.Marksmanship = marksmanship;
            this.Piloting = piloting;
            this.Luck = luck;
            this.Defense = defense;
        }
    }
}
