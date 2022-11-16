using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM_SUBMISSION_ASSIGNMENT
{
    public class Employee : IQuittable // Created Employee class and had it inherit IQuittable interface
    {
        public void Quit() // implements Quit method specific to how its used for an employee
        {
            Console.WriteLine("Thanks for playing, please come again.");
        }
        
        
                  
    }
}
