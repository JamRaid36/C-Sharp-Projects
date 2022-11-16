using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates a Math object and calls operation method
           
            Math math1 = new Math();
          
            Console.WriteLine(math1.Operation(5)); //takes an integer, returns an integer

            Math math2 = new Math();

            Console.WriteLine(math2.Operation(10.5)); //takes an decimal, returns an integer

            Math math3 = new Math();

            Console.WriteLine(math3.Operation("15")); //takes an string, returns an integer

            Console.ReadLine();
        }
    }
}
