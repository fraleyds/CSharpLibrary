using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Circle : Shape
    {
        //Constructor
        public Circle(int radius)
        {
            this.Radius = radius;
        }

        //Properties
        public int Radius { get; set; }


        //Methods
        public override double Area()
        {
            return (Math.Pow(Radius, 2) * Math.PI);
        }
    }
}
