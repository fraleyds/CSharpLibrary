using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ConstructorChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone davidsPhone = new MobilePhone("iPhone", "5s", "David");
            //Console.WriteLine($"My phone is the {davidsPhone.Make} {davidsPhone.Model}.");
            MobilePhone ricksPhone = new MobilePhone("Samsung", "Galaxy S4", "Rick");
            MobilePhone angiesPhone = new MobilePhone("Motorola", "Thingie", "Angie");
            MobilePhone rogersPhone = new MobilePhone("Nokia", "3310", "Roger");
            MobilePhone stevesPhone = new MobilePhone("Google", "Pixel", "Steve");

            string[] phoneMakes = new string[] { davidsPhone.Make, ricksPhone.Make, angiesPhone.Make, rogersPhone.Make, stevesPhone.Make };
            string[] phoneModels = new string[] { davidsPhone.Model, ricksPhone.Model, angiesPhone.Model, rogersPhone.Model, stevesPhone.Model };
            string[] phoneOwners = new string[] { davidsPhone.Owner, ricksPhone.Owner, angiesPhone.Owner, rogersPhone.Owner, stevesPhone.Owner };

            for (int i = 0; i < phoneMakes.Length; i++)
            {
                Console.WriteLine($"{phoneOwners[i]} has the {phoneMakes[i]} {phoneModels[i]}.");
            }
        }
    }
}
