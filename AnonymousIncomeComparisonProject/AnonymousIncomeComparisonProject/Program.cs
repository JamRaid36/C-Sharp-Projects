using System;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person 1's data entry

            Console.WriteLine("Anonymous Income Comparison Program\n");//Prints string
            Console.WriteLine("Person 1:");//Prints string
            Console.WriteLine("Hourly Rate?");//Prints string
            string hourlyRateP1 = Console.ReadLine();//Stores the hourly rate string
            int hrRateP1 = Convert.ToInt32(hourlyRateP1);//converts hourly rate string to integer datatype for future mathmatical operations
            Console.WriteLine("Hours worked per week?");//Prints string
            string weeklyHoursP1 = Console.ReadLine();//Stores the hourly rate string
            int wkHrsP1 = Convert.ToInt32(weeklyHoursP1);//converts weekly hours string to integer datatype for future mathmatical operations
            
            //Person 2's data entry

            Console.WriteLine("\nPerson 2:");//Prints string
            Console.WriteLine("Hourly Rate?");//Prints string
            string hourlyRateP2 = Console.ReadLine();//Stores the hourly rate string
            int hrRateP2 = Convert.ToInt32(hourlyRateP2);//converts hourly rate string to integer datatype for future mathmatical operations
            Console.WriteLine("Hours worked per week?");//Prints string
            string weeklyHoursP2 = Console.ReadLine();//Stores the hourly rate string
            int wkHrsP2 = Convert.ToInt32(weeklyHoursP2);//converts weekly hours string to integer datatype for future mathmatical operations

            //Print annual salary of Person 1

            int annualSalP1 = hrRateP1 * wkHrsP1 * 52;
            Console.WriteLine("\nAnnual Salary of Person 1:");//Prints string
            Console.WriteLine(annualSalP1);//Prints Person 2's annual salary

            //Print annual salary of Person 2

            int annualSalP2 = hrRateP2 * wkHrsP2 * 52;
            Console.WriteLine("\nAnnual Salary of Person 2:");//Prints string
            Console.WriteLine(annualSalP2);//Prints Person 1's annual salary

            //Print comparison of annual salaries with Boolean

            bool doesP1MakeMoreThanP2 = annualSalP1 > annualSalP2; // compares Person 1 and Person 2 annual salary's
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");//Prints string
            Console.WriteLine(doesP1MakeMoreThanP2);
            
            Console.ReadLine();
        }
    }
}