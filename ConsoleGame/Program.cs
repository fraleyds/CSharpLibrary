using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set up for speech synthesizer
            SpeechSynthesizer synth = new SpeechSynthesizer();

            //Introduction
            Console.WriteLine("Space Trip: The Gates of the Spacy Abyss");
            synth.Speak("Space Trip!");
            Console.WriteLine("Press RETURN to continue...");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.Clear();

            //Character Creation
            Console.WriteLine("Congratulations on acquiring your Captain's License!\n" +
                "And thank you for taking the time to respond our automated survey.");
            Console.WriteLine("Now to start things off, what is your name?");

            Player hero = new Player(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Thank you, {hero.Name}. Just a couple questions.\n" +
                $"Press RETURN to continue...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Now to talk about your training.\n" +
                "Did you feel more proficient as a pilot or at personal combat?\n" +
                $"1. Piloting\n" +
                $"2. Marksmanship");
            while (hero.Piloting == 0)
            {
                int statReply = Convert.ToInt32(Console.ReadLine());
                if (statReply == 1)
                {
                    hero.Piloting = 20;
                    hero.Marksmanship = 15;
                    Console.WriteLine("Ah, good to see another successful space pilot graduate our program.\n" +
                        "Press RETURN to continue...");
                    synth.Speak("Pilot proficiency get!");
                    Console.ReadLine();
                }
                else if (statReply == 2)
                {
                    hero.Piloting = 15;
                    hero.Marksmanship = 20;
                    Console.WriteLine("A natural marksman, are ya? How interesting.\n" +
                        "Press RETURN to continue.");
                    synth.Speak("Marksmanship proficiency get!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That's not a valid response. Just 1 or 2. Piloting or personal combat?");
                    synth.Speak("Invalid answer-giving proficiency get!");
                }
            }
            Console.Clear();

            Console.WriteLine("And what kind of ship do you fly now?\n" +
                "1. S-62 Jackal: Popular fighter for newbies. High attack, low defense.\n" +
                "2. RQ-12 Armadillo: For cautious types. Heavy shielding but not much weaponry.\n" +
                "3. PV-C Echo: A weird, rare ship that relies on special attacks.");
            int i = 0;
            Ship heroShip = new Ship();

            while (i == 0)
            {
                int shipReply = Int32.Parse(Console.ReadLine());
                if (shipReply == 1)
                {
                    heroShip.Name = "Jackal";
                    heroShip.Hull = 2000;
                    heroShip.MaxHull = 2000;
                    heroShip.Damage = 300;
                    heroShip.Defense = 100;
                    heroShip.Evasion = 0.007;
                    heroShip.Charge = 250;
                    heroShip.Value = 90000;
                    i++;
                }
                else if (shipReply == 2)
                {
                    heroShip.Name = "Armadillo";
                    heroShip.Hull = 2400;
                    heroShip.MaxHull = 2400;
                    heroShip.Damage = 200;
                    heroShip.Defense = 150;
                    heroShip.Evasion = 0.005;
                    heroShip.Charge = 250;
                    heroShip.Value = 90000;
                    i++;
                }
                else if (shipReply == 3)
                {
                    heroShip.Name = "Echo";
                    heroShip.Hull = 1900;
                    heroShip.MaxHull = 1900;
                    heroShip.Damage = 200;
                    heroShip.Defense = 120;
                    heroShip.Evasion = 0.01;
                    heroShip.Charge = 1000 / 3;
                    heroShip.Value = 90000;
                    i++;
                }
                else
                {
                    Console.WriteLine("That's not a valid response. Enter a valid value.");
                }
            }

            Console.Clear();
            Console.WriteLine("Thanks for your responses! Carry on.\n" +
                "Press RETURN to exit the survey...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();

            //Shepard Station
            Station shepard = new Station("Shepard Station", false, 5);
            Console.WriteLine($"You look up from the public console and take in the sight of the sprawling \n" +
                $"station terminal around you. {shepard.Name} is a bustling hive \n" +
                $"of activity, with merchants, travelers, and mercenaries alike milling about.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Your communicator buzzes. Finally, it seems, there's a job for you\n" +
                $"Soon, you're face to face with a portly fellow with a bushy mustache.\n" +
                $"\"Nice to meet you, {hero.Name}! Here's the digs:\"");
            Console.ReadLine();
            Console.Clear();

            Station grissom = new Station("Grissom Station", true, 2);
            Console.WriteLine($"\"We need you to deliver a parcel to {grissom.Name}, and\n" +
                $"we need it done quickly. Can you do that for us, {hero.Name}?\"\n" +
                $"Enter y/n:");
            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                Console.WriteLine("\"Excellent. I'll have it sent to your ship.\"");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Enraged, he pulls out a blaster and shoots you several times.\n" +
                    "You have died. You should have hit y.");
                Environment.Exit(1);
            }

            Console.Clear();
            Console.WriteLine($"You head back to your {heroShip.Name}, where a courier for your\n" +
                $"new employer is sticking a package into the small cargo bay.\n\n" +
                $"He nods and leaves, and you settle into your seat, and within a few minutes\n" +
                $"you're shooting off into space...");
            Console.ReadLine();
            Console.Clear();

            //Sector Charlie
            Sector charlie = new Sector("Sector Charlie");
            Console.WriteLine($"You begin your flight through {charlie.Name}.\n" +
                $"All is initially peaceful, until a barrage of laser bolts cross your bow!");
            synth.Speak("Stand and deliver, courier. Your money or your life!");

            Ship ibis = new Ship()
            {
                Name = "Ibis",
                Hull = 2700,
                Damage = 280,
                Defense = 75,
                Evasion = 0.003
            };
            NPC harold = new NPC("Harold", "the Butcher", 1, 1, 16, 16, 10, 0);

            Battle firstFight = new Battle();
            firstFight.Combat(hero, heroShip, harold, ibis);
            if (hero.IsAlive == false)
            {
                Environment.Exit(1);
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The rest of your journey is uneventful. You arrive at your destination.\n");
            Console.ReadLine();
            Console.WriteLine("A wiry dude with a goatee takes your offered parcel and nods.\n" +
                $"\"Thank you, {hero.Name}. I'm sure it was a harrowing journey.\"");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("You're paid a million bucks and win the game in its current state. Congrats.");
        }
    }
}
