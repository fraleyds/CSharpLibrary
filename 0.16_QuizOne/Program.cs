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
            Triangle triangleOne = new Triangle(2, 4);
            Console.WriteLine($"Area = {triangleOne.Area()}");

            Triangle triangleTwo = new Triangle(3, 1);
            Console.WriteLine($"Area = {triangleTwo.Area()}");

            Triangle triangleThree = new Triangle(20, 4);
            Console.WriteLine($"Area = {triangleThree.Area()}");

            Triangle triangleFour = new Triangle(900, 67);
            Console.WriteLine($"Area = {triangleFour.Area()}");

            Triangle triangleFive = new Triangle(78, 52);
            Console.WriteLine($"Area = {triangleFive.Area()}");
        }
    }
}
