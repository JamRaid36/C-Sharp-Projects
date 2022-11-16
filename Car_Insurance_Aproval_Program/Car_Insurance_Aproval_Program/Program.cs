using System;


namespace Car_Insurance_Aproval_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Aproval Program\n");//Prints string
            Console.WriteLine("What is your age?");//Prints string
            string applicantAge = Console.ReadLine();//Stores age string
            int appAge = Convert.ToInt32(applicantAge);//converts age string to integer data type for future mathmatical operations
            Console.WriteLine("\nHave you ever had a DUI? Please answer \"true\" or \"false\".");//Prints string
            string noDui = Console.ReadLine();//Stores the page need help string
            bool nDui = Convert.ToBoolean(noDui);//converts string to boolean datatype
            Console.WriteLine("\nHow many speeding tickets have you had?");//Prints string
            string speedingTickets = Console.ReadLine();//Stores speeding tickets string
            int spdTickets = Convert.ToInt32(speedingTickets);//converts speeding tickets string to integer data type for future mathmatical operations

            // This is the boolean comparison that determines insurance approval

            bool insuranceApprovel = (appAge >= 15 != nDui && spdTickets <= 3); //age must be 15 or higher, DUI boolean must not be true and applicant must have 3 or less speeding tickets
            Console.WriteLine("\nDoes applicant qualify?");
            Console.WriteLine(insuranceApprovel); //Prints approval result
            Console.ReadLine();
        }
    }
}