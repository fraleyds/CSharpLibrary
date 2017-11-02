using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces_Collections_Pseudo
{
    class ArrayClass : IEnum, IList, ICollect
    {
        public void IterateOverCollection()
        {
            Console.WriteLine("Iterating over the array...");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Removed stuff from the array...");
        }

        public void AddStuff()
        {
            Console.WriteLine("Added stuff to the array...");
        }

        public void CheckCount()
        {
            Console.WriteLine("Checking the count of the array...");
        }

        public void CheckCapacity()
        {
            Console.WriteLine("You can't check the capacity of the array...");
        }
    }
}
