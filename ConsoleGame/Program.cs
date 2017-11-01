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
            Console.ReadLine();
            Console.Clear();

            //Character Creation
            Console.WriteLine("Congratulations on acquiring your Captain's License!\n" +
                "And thank you for taking the time to respond our automated survey.");
            Console.WriteLine("Now to start things off, what is your name?");

            Player hero = new Player(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Just a few questions for you, {hero.Name}.\n" +
                $"Press RETURN to continue...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Now to talk about your training.\n" +
                "Did you feel more proficient as a pilot or at personal combat?\n" +
                $"1. Piloting\n" +
                $"2. Boots-on-the-ground Combat");
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
            Thread.Sleep(500);
            Console.WriteLine("Thanks for your responses! Carry on.\n" +
                "Press RETURN to exit the survey...");
        }
    }
}
