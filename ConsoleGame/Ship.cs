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
        public double MaxHull { get; set; }

        //Enum
        public enum CombatAction
        {
            Attack,
            ChargeShot,
            SelfDestruct
        }

        //Methods
        public double Attack()
        {
            Random rnd = new Random();
            double spread = rnd.Next(-55, 56);
            double damage = this.Damage + spread;
            return damage;
        }
        public double ChargeAttack()
        {
            Random rnd = new Random();
            double spread = rnd.Next(-20, 101);
            double damage = this.Damage * 3 + spread;
            return damage;
        }
    }
}
