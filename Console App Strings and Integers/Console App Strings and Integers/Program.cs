using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Strings_and_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            try // Test code block for exceptions
            {
                List<int> numbers = new List<int>() { 12, 14, 24, 22, 100 }; // Creates List of integers
                Console.WriteLine("Enter a number to divide each number in the list with"); // displays user instructions
                int num = Convert.ToInt32(Console.ReadLine()); // converts user string to integer for math functions

                for (int i = 0; i < numbers.Count; i++) //iterates through list and performs math function on each integer in the list
                {
                    int quotient = numbers[i] / num;
                    Console.WriteLine(quotient); //displays quotient
                }
            }
            catch (FormatException ex) // checks to make sure user has used the proper input format
            {
                Console.WriteLine(ex.Message);// displays the exact error to user
            }
            catch (DivideByZeroException ex) //checks to make sure user has not attempted to divide by zero
            {
                Console.WriteLine(ex.Message); // displays the exact error to user
            }
            finally
            {
                Console.ReadLine(); //ensures program pauses and is read
            }
            Console.WriteLine("Program has emerged out of the try catch block."); // ensure program has exited the try catch
            Console.ReadLine();


        }
    }
}
