using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_OOPGame
{
    public abstract class Character
    {
        //Constants
        const int Min_Health = 0;

        //Properties
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }

        //Methods
        public int Attack(int strength)
        {
            Random rnd = new Random();
            int damage = rnd.Next(1, strength);
            return damage;
        }
    }
}
