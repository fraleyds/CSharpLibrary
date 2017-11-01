using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Square : Shape
    {
        //Constructor
        public Square(int length)
        {
            this.SideLength = length;
        }

        //Constants
        public const int NUM_SIDES = 4;

        //Properties
        public int SideLength { get; set; }

        //Methods
        public override double Area()
        {
            return Math.Pow(SideLength, 2);
        }
    }
}
