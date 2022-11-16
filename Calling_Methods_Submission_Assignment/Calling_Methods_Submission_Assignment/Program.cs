using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // This instantiates a UserMath object 
            // Then asks user to input a number
            // user input is then converted to an integer and assigned to the UserNum property of UserMath Class
            UserMath user = new UserMath();
            Console.WriteLine("please enter a number to perform math operations on");
            user.UserNum = Convert.ToInt32(Console.ReadLine());


            // This calls 3 UserMath methods and prints the outputs

            Console.WriteLine("\n");
            Console.WriteLine(user.UserNum + " + 10 = " + user.AddTen());

            Console.WriteLine("\n");
            Console.WriteLine(user.UserNum + " / 2 = " + user.DivideByTwo());

            Console.WriteLine("\n");
            Console.WriteLine(user.UserNum + " * 2 = " + user.MultiplyByTwo());

            Console.ReadLine();
        }
        
    }
}
