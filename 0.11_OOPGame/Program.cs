using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_OOPGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newHero = new Player();
            Creature moose = new Creature();

            Console.WriteLine("Howdy. \n" +
                "What be thy name?");
            newHero.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Ah! So thy name is {newHero.Name}!");

            Console.WriteLine("What's your class?\n" +
                "1. Fighter\n" +
                "2. Archer\n" +
                "3. Mage\n" +
                "4. Barbarian\n" +
                "5. Dragon");

            Player.Specialization = int.Parse(Console.ReadLine());
        }
    }
}
