using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATE_TIME_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);// This prints the current date and time 
            Console.WriteLine("Please enter a number.");//asks user for number input
            int x = Convert.ToInt32(Console.ReadLine());//assigns input to an int variable
            TimeSpan userHours = new TimeSpan(0, x, 0, 0); //creates a timespan variable and passes int x as a parameter
            DateTime currentTime = DateTime.Now; // creates datetime varaiable woth the current date and time
            DateTime futureTime = currentTime.Add(userHours); // adds the timespan variable to the datetime currenttime variable and assigns it a to futuretime variable
            string fTime = futureTime.ToString("hh:mm tt"); // converts datetime variable (futuretime) to a string that holds specific parameters of the datetime variable
            Console.WriteLine("In " + x + " hours it will be " + fTime);// diplays the eaxct time it will be in the ammount of hours that the user entered in the begining
            Console.ReadLine();

            
            

           

        }
    }
}
