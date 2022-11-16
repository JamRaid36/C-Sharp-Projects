using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmissionAssignment
{
    public enum WeekDay //Created Weekday Enum
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            try // added try 
            {
                Console.WriteLine("Please enter the current day of the week"); // Requested User Input
                WeekDay dayOfTheWeek = (WeekDay)Enum.Parse(typeof(WeekDay), Console.ReadLine(), true); // Converted user input to enum and usd bool parameter to ignore case sensitivity
                //Console.WriteLine(dayOfTheWeek);  // optional line to print variable to the console         
            }
            catch (Exception) // exception handle
            {
                Console.WriteLine("Please enter an actual day of the week."); // message to user if exception occurs
            }
            finally
            {
                Console.ReadLine(); // ReadLine so program doesn't immediately close at the end
            }


        }
    }
}
