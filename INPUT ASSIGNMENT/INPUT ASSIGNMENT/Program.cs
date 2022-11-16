using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace INPUT_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number"); // asks user to enter text
            string number = Console.ReadLine(); // assigns user entry to string variable
            File.WriteAllText(@"C:\Users\guita\Desktop\InputAssignment\log.txt", number); //writes text to a txt file if file doesnt exist it creates the txt file.
            Console.WriteLine("You entered: " + File.ReadAllText(@"C:\Users\guita\Desktop\InputAssignment\log.txt"));//prints a message and concatonates with text in the file.
            Console.ReadLine();


        }
    }
}
