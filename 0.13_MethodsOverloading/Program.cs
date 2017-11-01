using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_MethodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player hero = new Player();
            hero.Attack(20);
            hero.Attack(60, "a rusty spoon");
            hero.Attack(30, "a rock", 4);
        }
    }
}
