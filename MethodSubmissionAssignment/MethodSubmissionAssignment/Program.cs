using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MSA msa1 = new MSA(); //Creates instance of MSA class object
            Console.WriteLine("Please enter 2 numbers one at a time."); // asks user for p1 parameter
            int x = Convert.ToInt32(Console.ReadLine()); // converts input parameter to integer
            Console.WriteLine("Pick another number or leave blank"); // reuqests second optional parameter (p2) or to just leave blank letting the default parameter be used
            string y = Console.ReadLine(); // assigns second user input to a string variable
            if (y == "") //If statement used to determine what step to take if user input is left blank or if user provides input
            {
                Console.WriteLine(msa1.TwoInts(x)); //If user input is left blank than TwoInts method is perfomred with p1 parameter and default p2 parameter
            }
            else
            {
                int intY = Convert.ToInt32(y); // if user provides input for the second parameter it is converted to an integer and assigned to intY variable
                Console.WriteLine(msa1.TwoInts(x, intY)); // now TwoInts method passes the required user parameter and optional parameter input data from the user 
            }
            Console.ReadLine();
        }
    }
}
