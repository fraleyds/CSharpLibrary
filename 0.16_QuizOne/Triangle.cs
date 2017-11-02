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
        public Triangle()
        {

        }

        //Properties
        public int TBase { get; set; }
        public int THeight { get; set; }
        public double TArea { get; set; }
        public string TName { get; set; }

        //Methods
        public override double Area()
        {
            TArea = ((TBase * THeight) / 2);
            Console.WriteLine(TArea);
            return TArea;
        }

    }
}
