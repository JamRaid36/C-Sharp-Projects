using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            CSA csa1 = new CSA(); // Instantiates a CSA object
            Console.WriteLine("Please enter a number."); // Asks user for a number
            int x = Convert.ToInt32(Console.ReadLine()); //assigns user input to variable int x and converts the user string to an integer
            csa1.VMeth(x); //calls void method
            CSA csa2 = new CSA(); // Instantiates a CSA object
            int num = 0; // variable that recieves output from void method ReturnNumber
            csa2.ReturnNumber(out num); //Void method that contains output parameter
            Console.WriteLine(num); // prints num variable once it recieves output info from void method ReturnNumber
            CSA csa3 = new CSA(); // Instantiates a CSA object
            Console.WriteLine("Please enter a decimal number."); // Asks user for a decimal number
            double y = Convert.ToDouble(Console.ReadLine()); // converts user input to a double and assigns it to variable for use with overload methed VMeth 
            csa3.VMeth(y);//calls overload method VMeth which utilizes a double and does a math operation on user input


            Console.ReadLine();

        }
    }
}
