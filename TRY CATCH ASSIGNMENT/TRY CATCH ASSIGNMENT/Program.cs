using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRY_CATCH_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {

            try // try catch
            {
                Console.WriteLine("Please enter your age");// asks user to enter age
                int userAge = Convert.ToInt32(Console.ReadLine()); //converts age to int

                if(userAge < 1) // if user enters anything below 1 a format excepetion will be thrown
                {
                    throw new FormatException();
                } 

                int userAgeToNegative = userAge * -1; // converts int to its negative counterpart
                DateTime userBirthYear = DateTime.Now.AddYears(userAgeToNegative); //adds negative int userAgeToNegative to datetime estimating a relative birth year for the user
                string birthYear = userBirthYear.ToString("yyyy"); //converts Datetime variable to a string and selects only the year to be used
                Console.WriteLine("You were born in the year " + birthYear + ".");// displays the relative birth year to the console
                Console.ReadLine(); 
            }
            catch(FormatException) // if format exception is thrown this will catch it and display a message 
            {
                Console.WriteLine("Please only enter positive numbers greater than 0.");
                Console.ReadLine();              
            }
            catch (Exception e) //if any exception is thrown this will catch it and display a message
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }


        }
    }
}
