using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUB_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args) // Instantiated Employee object with properties and virtual method taken from Abtsract person class
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();
        }
    }
}
