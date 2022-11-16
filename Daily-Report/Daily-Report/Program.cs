using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy\n\nStudent Daily Report");//Prints string
            Console.WriteLine("What is your name?");//Prints string
            string studentName = Console.ReadLine();//Stores the name string
            Console.WriteLine("What course are you on?");//Prints string
            string currentCourse = Console.ReadLine();//Stores the course string
            Console.WriteLine("What page number are you on?");//Prints string
            string currentPageNumber = Console.ReadLine();//Stores the page number string
            int CurPgNum = Convert.ToInt32(currentPageNumber);//converts page number string to integer datatype for future mathmatical operations
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");//Prints string
            string needHelp = Console.ReadLine();//Stores the page need help string
            bool studentNeedHp = Convert.ToBoolean(needHelp);//converts string to boolean datatype
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");//Prints string
            string positiveExp = Console.ReadLine();//Stores the positive experience string
            Console.WriteLine("Is there an other feedback you'd like to provide? Please be specific.");//Prints string
            string studentFeedback = Console.ReadLine();//Stores the student feedback string
            Console.WriteLine("How many hours did you study today?");//Prints string
            string studiedHours = Console.ReadLine();//Stores the number of hours string
            int todaysStudyHrs = Convert.ToInt32(studiedHours);//converts to integer datatype for future mathmatical operations
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.\nHave a nice day!\n\nThis is the end of the program!");//Prints string
            Console.ReadLine();
        }
    }
}
