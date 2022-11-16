using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable emp1 = new Employee(); // utilized polymorphism to instantiate an object of interface type
            emp1.Quit(); // calls employee version of quit method
            Console.ReadLine();
        }
    }
}
