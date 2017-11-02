using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces_Collections_Pseudo
{
    class ListClass : IEnum, IList, ICollect
    {
        public void AddStuff()
        {
            Console.WriteLine("Add stuff to list");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Remove stuff from list");
        }

        public void CheckCapacity()
        {
            Console.WriteLine("Check capacity of list");
        }

        public void CheckCount()
        {
            Console.WriteLine("Check count of list");
        }

        public void IterateOverCollection()
        {
            Console.WriteLine("Iterate over list");
        }
    }
}
