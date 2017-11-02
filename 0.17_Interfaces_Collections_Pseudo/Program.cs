using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces_Collections_Pseudo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayClass exampleArrayClass = new ArrayClass();
            exampleArrayClass.CheckCapacity();

            ListClass exampleListClass = new ListClass();
            exampleListClass.CheckCapacity();
        }
    }
}
