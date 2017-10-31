using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_OOP_Game_BuildAlong
{
    class Enemy : Character
    {
        public Enemy(string name, int level)
        {
            this.Name = name;
            this.IsAlive = true;
            this.Health = 100;
            this.Level = level;
            this.AttackPower = 8;
            this.CritChance = 0.20;
        }
    }
}
