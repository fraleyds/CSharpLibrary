using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_QuizOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            Triangle triangleOne = new Triangle(2, 4);
            Triangle triangleTwo = new Triangle(3, 2);
            Triangle triangleThree = new Triangle(20, 4);
            Triangle triangleFour = new Triangle(900, 67);
            Triangle triangleFive = new Triangle(78, 52);

            triangleOne.Area();
            triangleTwo.Area();
            triangleThree.Area();
            triangleFour.Area();
            triangleFive.Area();

            //Problem 2
            IEnumerable<Triangle> triangles = new List<Triangle>()
            {
                new Triangle {TBase=3,THeight=2,TName="Triangle 1"},
                new Triangle {TBase=5,THeight=5,TName="Triangle 2"},
                new Triangle {TBase=1,THeight=3,TName="Triangle 3"},
                new Triangle {TBase=6,THeight=15,TName = "Triangle 4"},
                new Triangle {TBase=8,THeight=3,TName="Triangle 5"},
                new Triangle {TBase=90,THeight=123, TName="Triangle 6"},
                new Triangle {TBase=6,THeight=6,TName="Triangle 7"},
            };

            IEnumerable<Triangle> query = from t in triangles
                                          where t.Area() > 10
                                          orderby t.TArea ascending
                                          select t;

            foreach (Triangle triangle in query)
            {
                Console.WriteLine(triangle.TName + " " + triangle.TArea);
            }
        }
    }
}
