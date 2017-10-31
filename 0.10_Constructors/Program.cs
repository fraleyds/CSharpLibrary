using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student jayStudent = new Student("Jay", "Jackson", 5, 1);
            Student davidStudent = new Student(23, "David", "Fraley");
        }
    }
}
