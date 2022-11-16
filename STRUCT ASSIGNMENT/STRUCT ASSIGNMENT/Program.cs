using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUCT_ASSIGNMENT
{
    struct Number
    {
        public decimal Amount; // created struct with decimal type property
    }


    class Program
    {
        static void Main(string[] args)
        {
            Number Num1; //initaialized Number object
            Num1.Amount = 2.5M; // assigned a decimal value to the object
            Console.WriteLine(Num1.Amount); // prints object amount value to the console
            Console.ReadLine();
        }
    }
}
