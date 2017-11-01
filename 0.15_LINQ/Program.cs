using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new array of instructors
            string[] instructors = { "Jay", "Paul", "Kenn", "Dave", "Auri" };

            //Set up the query
            IEnumerable<string> query = from i in instructors
                                        where i.Length == 4
                                        select i;

            //Loop through the array using the query
            foreach (string name in query)
            {
                //Console.WriteLine(name);
            }

            //EXAMPLE 2
            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee {ID=1,Name="JohnBoy",HireDate=new DateTime(2016,3,5)},
                new Employee {ID=2,Name="Susan",HireDate=new DateTime(1902,4,12)},
                new Employee {ID=3,Name="A A Ron",HireDate=new DateTime(2016,12,12)},
                new Employee {ID=4,Name="Balakay",HireDate=new DateTime(1956,1,1)},
                new Employee {ID=5,Name="Keisha",HireDate=new DateTime(2016,6,8)}
            };

            IEnumerable<Employee> queryTwo = from e in employees
                                             where e.HireDate.Year == 2016
                                             orderby e.Name ascending
                                             select e;

            foreach (Employee employee in queryTwo)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
