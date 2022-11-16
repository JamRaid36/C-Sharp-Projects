 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() // created a list of employees
            {
                new Employee(){ID = 1, FirstName = "Jason", LastName = "Rogan" },
                new Employee(){ID = 2, FirstName = "Joe", LastName = "Cookie" },
                new Employee(){ID = 3, FirstName = "Danny", LastName = "Alpo" },
                new Employee(){ID = 4, FirstName = "Preston", LastName = "Bear" },
                new Employee(){ID = 5, FirstName = "Jasmin", LastName = "Savage" },
                new Employee(){ID = 6, FirstName = "Joe", LastName = "Gilkirk" },
                new Employee(){ID = 7, FirstName = "Costa", LastName = "Darling" },
                new Employee(){ID = 8, FirstName = "Chirstopher", LastName = "Colbert" },
                new Employee(){ID = 9, FirstName = "Jennifer", LastName = "Yasmin" },
                new Employee(){ID = 10, FirstName = "Sarah", LastName = "Hardy" },
            };

            // added a foreach loop to iterate through the employees list and find all objects with the first name Joe and add them to a new list

            //int counter = 0;
            //List<Employee> newList = new List<Employee>();
            //foreach (Employee employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        newList.Add(employee);
            //        counter++;
            //    }
            //}

            List<Employee> newList = employees.Where(x => x.FirstName == "Joe").ToList(); // used a LAMBDA expression to do the same thing as my previous for each loop

            List<Employee> newList2 = employees.Where(x => x.ID > 5).ToList(); // used a LAMBDA expression to add all employees with an ID greater than 5 to a new list



            // foreach loop to check list contents

            //foreach (Employee employee in newList2)
            //{
            //    Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //}
            Console.ReadLine();
        }
    }
}
