using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_GetterSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();

            Console.WriteLine("Enter Employee Name: ");
            newEmployee.Name = Console.ReadLine();

            Console.WriteLine("Enter Employee ID: ");
            newEmployee.ID = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"New Employee: {newEmployee.Name} {newEmployee.ID}");

            //Set work quote
            Console.WriteLine($"Enter a common quote for {newEmployee.Name}");
            newEmployee.SetWorkQuote(Console.ReadLine());

            //Get work quote
            Console.WriteLine(newEmployee.GetQuote());
        }
    }
}
