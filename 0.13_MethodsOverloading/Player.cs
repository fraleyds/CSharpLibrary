using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_MethodsOverloading
{
    class Player
    {
        //Methods
        public void Attack(int damage)
        {
            Console.WriteLine($"Attacked for {damage} damage!");
        }
        public void Attack(int damage, string weapon)
        {
            Console.WriteLine($"Attacked with {weapon} for {damage} damage!");
        }
        public void Attack(int damage, string weapon, int iterations)
        {
            Console.WriteLine($"Attacked with {weapon} for {damage} {iterations} times, for a total of {damage * iterations} damage!");
        }
    }
}
