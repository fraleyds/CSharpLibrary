using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_ArraysChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //BRONZE
            string[] favoriteFoods = new string[3] { "Ravioli", "Quesadillas", "Cheeseburgers"};
            //foreach (string food in favoriteFoods)
            //{
            //    Console.WriteLine(food);
            //}

            //SILVER
            int[] numbers1 = new int[5] { 3, 5, 66, 2, 41 };
            int[] numbers2 = new int[5] { 62, 400, 2, 5, 11 };
            int[] numberSums = new int[numbers1.Length];
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    numberSums[i] = numbers1[i] +numbers2[i];
            //    Console.WriteLine(numberSums[i]);
            //}

            //GOLD
            int[] randoNums = new int[10];
            Random random = new Random();
            int randomNumber;

            for (int i = 0; i < randoNums.Length; i++)
            {
                randomNumber = random.Next(0, 100);
                randoNums[i] = randomNumber;
                Console.WriteLine(randoNums[i]);
            }
        }
    }
}
