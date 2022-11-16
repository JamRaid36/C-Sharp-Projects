using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(); // instantaited employee object and gave it properties and an inherited method from Person class
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            employee1.SayName();
            Console.ReadLine();
           



        }
    }
}
