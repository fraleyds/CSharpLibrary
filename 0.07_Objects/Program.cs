using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut paulDonut = new Donut();
            Donut kennDonut = new Donut();
            Donut davidDonut = new Donut();

            paulDonut.Filling = "Cherry Jelly";
            paulDonut.Price = 7.99M;
            paulDonut.Type = "Jelly";
            paulDonut.IsSpecial = true;

            kennDonut.Filling = "Strawberry Jelly";
            kennDonut.Price = 0;
            kennDonut.Type = "Jelly";
            kennDonut.IsSpecial = false;

            davidDonut.Filling = "Cream";
            davidDonut.Price = 0.89M;
            davidDonut.Type = "Cream";
            davidDonut.IsSpecial = true;
        }
    }
}
