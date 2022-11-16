using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(); // Instantiated new object
            employee1.FirstName = "Jesse";
            employee1.LastName = "Gilchrist";
            employee1.ID = 122;

            Employee employee2 = new Employee(); // Instantiated new object
            employee2.FirstName = "Jim";
            employee2.LastName = "Berret";
            employee2.ID = 123;

            Console.WriteLine("True or False, Jesse and Jim have the same ID"); // prints true opr false statement
            Console.WriteLine(employee1.ID == employee2.ID); // prints true or false as the answer to above question
            Console.ReadLine();
        }
    }
}
