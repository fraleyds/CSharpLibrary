using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Battle
    {
        ////Constructor
        //public Battle(Player hero, Ship heroShip, NPC enemy, Ship enemyShip)
        //{
        //    this.Hero = hero;
        //    this.HeroShip = heroShip;
        //    this.Enemy = enemy;
        //    this.EnemyShip = enemyShip;
        //}

        ////Properties
        //public Player Hero { get; set; }
        //public Ship HeroShip { get; set; }
        //public NPC Enemy { get; set; }
        //public Ship EnemyShip { get; set; }

        //Methods
        public void Combat(Player hero, Ship heroShip, NPC enemy, Ship enemyShip)
        {
            double charge = heroShip.Charge;
            Console.WriteLine($"A hostile {enemyShip.Name} appears!");
            Console.WriteLine($"\"Have at you, nerd! I am {enemy.Name} {enemy.Nickname}!\"");
            Console.ReadLine();
            Console.Clear();
            while (hero.IsAlive && enemy.IsAlive)
            {
                Console.WriteLine($"{heroShip.Name} Hull: {heroShip.Hull}\n" +
                    $"{enemyShip.Name} Hull: {enemyShip.Hull}\n" +
                    $"Current Charge: {charge}/900\n");
                Console.WriteLine("================================================\n");
                Console.WriteLine("What will you do?\n" +
                "1. Attack\n" +
                "2. Charge Shot\n" +
                "3. Self Destruct");

                int inputAction = (Int32.Parse(Console.ReadLine()) - 1);
                Ship.CombatAction combatAction = (Ship.CombatAction)inputAction;
                switch (combatAction)
                {
                    //Basic Attack
                    case Ship.CombatAction.Attack:
                        charge += heroShip.Charge;
                        double playerAttack = heroShip.Attack();
                        double enemyAttack = enemyShip.Attack();
                        Random rnd = new Random();
                        double heroHitNum = rnd.Next(101);
                        double enemyHitNum = rnd.Next(101);
                        if (heroHitNum > (enemyShip.Evasion * enemy.Piloting * 100))
                        {
                            enemyShip.Hull -= (playerAttack - enemyShip.Defense);
                            Console.WriteLine($"Your shots strike true, dealing {playerAttack - enemyShip.Defense} damage to the {enemyShip.Name}'s hull!\n");
                        }
                        else
                        {
                            Console.WriteLine($"Your shots go wide, whizzing past the {enemyShip.Name} and into the darkness.\n");
                        }
                        if (enemyHitNum > (heroShip.Evasion * hero.Piloting * 100))
                        {
                            heroShip.Hull -= (enemyAttack - heroShip.Defense);
                            Console.WriteLine($"Your ship shudders as {enemy.Name}'s attack strikes, doing {enemyAttack - heroShip.Defense} damage to your hull.");
                        }
                        else
                        {
                            Console.WriteLine($"{enemy.Name}'s attack misses. You let out a breath you didn't know you were holding.");
                        }
                        break;

                    //Special Attack
                    case Ship.CombatAction.ChargeShot:
                        if (charge >= 900)
                        {
                            charge -= 900;
                            double playerCharge = heroShip.ChargeAttack();
                            double enemyCharge = enemyShip.Attack();
                            Random random = new Random();
                            double heroHit = random.Next(101);
                            double enemyHit = random.Next(101);
                            if (heroHit > (enemyShip.Evasion * enemy.Piloting * 100))
                            {
                                enemyShip.Hull -= (playerCharge - enemyShip.Defense);
                                Console.WriteLine($"Your charged strike bores into the {enemyShip.Name} for {playerCharge - enemyShip.Defense} damage,\n" +
                                    $"boring into the hull.\n");
                            }
                            else
                            {
                                Console.WriteLine($"Your shots go wide, whizzing past the {enemyShip.Name} and into the darkness.\n");
                            }
                            if (enemyHit > (heroShip.Evasion * hero.Piloting * 100))
                            {
                                heroShip.Hull -= (enemyCharge - heroShip.Defense);
                                Console.WriteLine($"Your ship shudders as {enemy.Name}'s attack strikes, doing {enemyCharge - heroShip.Defense} damage to your hull.");
                            }
                            else
                            {
                                Console.WriteLine($"{enemy.Name}'s attack misses. You let out a breath you didn't know you were holding.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You cannot use your Charge Attack until you have 1000 charge to use.");
                        }
                        break;

                    //Self Destruct
                    case Ship.CombatAction.SelfDestruct:
                        Console.WriteLine("Initializing self-destruct sequence...\n");
                        Thread.Sleep(1000);
                        Console.WriteLine("Your ship's reactor goes critical and you're consumed in a blinding light.\n" +
                            "You've died.");
                        hero.IsAlive = false;
                        break;

                    //Invalid Input
                    default:
                        Console.WriteLine("Your mother would be ashamed of you for entering an invalid input.");
                        break;
                }

                Console.WriteLine("Press RETURN to continue...");
                Console.ReadLine();
                Console.Clear();

                if (heroShip.Hull <= 0)
                {
                    Console.WriteLine($"The final hit of the {enemyShip.Name}'s weapon batteries hits your reactor, and in a flash\n" +
                        $"it's all over. You have died.");
                    hero.IsAlive = false;
                }
                if (enemyShip.Hull <= 0)
                {
                    Console.WriteLine($"A light fills your viewscreen for a moment as the {enemyShip.Name} ignites in a\n" +
                        $"breathtaking explosion. You have won.");
                    enemy.IsAlive = false;
                }
            }
        }
    }
}
