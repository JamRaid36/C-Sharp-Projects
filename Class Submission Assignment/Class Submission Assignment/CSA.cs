using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Assignment
{
    class CSA
    {
        public void VMeth(int p1)//void method
        {
            int p2 = (p1/2);// performs a math operation on p1 and assigns it to p2 variable    
            Console.WriteLine(p2);// displays 
        }



        public void ReturnNumber(out int number)//void method with output parameters
        {
            number = 12;
        }


        public void VMeth(double p1)//overload method for VMeth uses and returns a double instead of a regular integer
        {
            double p2 = (p1 / 2);// performs a math operation on p1 and assigns it to p2 variable    
            Console.WriteLine(p2);// answer as a double 
        }
    }
}
