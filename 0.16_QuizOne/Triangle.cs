using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_QuizOne
{
    class Triangle : Shape
    {
        //Constructor
        public Triangle(int tBase, int tHeight)
        {
            this.TBase = tBase;
            this.THeight = tHeight;
        }

        //Properties
        public int TBase { get; set; }
        public int THeight { get; set; }

        //Methods
        public override double Area()
        {
            return ((TBase * THeight) / 2);    
        }

    }
}
