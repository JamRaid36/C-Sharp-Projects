using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission_Assignment
{
    public class Employee // created employee class and set string and int properties
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public static bool operator == (Employee employeeA, Employee employeeB) // overloaded == operator
        {
            if (employeeA.ID == employeeB.ID) // compares object ID properties and returns truw or fals boolean
                return true;
            else
                return false;
        }
        public static bool operator != (Employee employeeA, Employee employeeB) // satisfies overloading operators in pairs rule
        {
            return !(employeeA.ID == employeeB.ID);  
        }
        public override bool Equals(object obj) //Overrides .Equals to satisfy warnings
        {
            return base.Equals(obj);
        }
        public override int GetHashCode() //Overrides .GetHashCode to satisfy warnings
        {
            return base.GetHashCode();
        }
    }
}
