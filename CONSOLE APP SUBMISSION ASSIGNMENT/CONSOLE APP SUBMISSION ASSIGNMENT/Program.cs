using System;


namespace CONSOLE_APP_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Loop");
            {
                int i = 0; // intializes i
                while (i < 10) // will continue loop as long i is less than 10
                {
                    Console.WriteLine(i);
                    i++;// adds 1 to i everytime it gets to this point so the next time i's value gets higher
                }
            }

            Console.WriteLine("Do While Loop"); // A do While loop allows for the intialization to get run before hitting the condition. This way even if j doesn't meet the requirements it still gets printed

            {
                int j = 0; // intializes j
                do
                {
                    Console.WriteLine(j);
                    j++;// adds 1 to j everytime it gets to this point so the next time j's value is higher
                }
                while (j < 0);

            }
            Console.ReadLine();
        }
    }
}
