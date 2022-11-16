using System;
using System.Collections.Generic;


namespace CONSOLE_APP_PART_1_6_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART 1

            //1. Creates an string array and asks user to input text
            string[] nameArray = { "Jason", "John", "Jim", "Jane", "Janice" };
            Console.WriteLine("Please input last name for this array"); //Asks user to input text
            string lastName = Console.ReadLine(); // stores input as lastName variable
            Console.WriteLine("\n");
            for (int i = 0; i < nameArray.Length; i++) // For loop adds string value of string index plus lastName to each index 
            {
                nameArray[i] += " " + lastName;
            }
            for (int j = 0; j < nameArray.Length; j++) // prints each item in the array
            {
                Console.WriteLine(nameArray[j]);
            }

            Console.WriteLine("\n");

            //PART 2

            //commenting out the first task to show work

            //while(true) //Creating and infinite while loop
            //{
            //    Console.WriteLine("This is an infinite loop!");
            //}

            int k = 0; // added initialization
            while (k < 10) // added condition to the loop
            {
                Console.WriteLine("This is not an infinite loop anymore!");
                k++; //Added update to k
            }

            Console.WriteLine("\n");

            //Part 3 
            Console.WriteLine("\n");
            for (int p = 0; p < 3; p++) // loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator 
            {
                Console.WriteLine("using the < conditon to iterate a loop");
            }

            Console.WriteLine("\n");
            for (int p = 0; p <= 3; p++) // loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator 
            {
                Console.WriteLine("using the <= conditon to iterate a loop");
            }

            Console.WriteLine("\n");

            //Part 4

            List<string> vehicles = new List<string>() { "truck", "car", "helicopter", "boat" };
            Console.WriteLine("Please input text you would like to search for in this list"); //Asks user to input text
            string stringMatch = Console.ReadLine();
            for (int i = 0; i < vehicles.Count;) //for loop iterates through list
            {
                if (vehicles.Contains(stringMatch)) // matches list string to user input
                {
                    Console.WriteLine(vehicles.IndexOf(stringMatch));
                    break; // breaks out of loop
                }
                else // triggers if no match is found
                {
                    Console.WriteLine("This input does not exist inside this list");
                    break; // breaks out of loop
                }
            }

            Console.WriteLine("\n");

            //Part 5

            List<string> shapes = new List<string>() { "square", "circle", "triangle", "circle" };
            Console.WriteLine("Please input text you would like to search for in the shapes list"); //Asks user to input text
            string shapeMatch = Console.ReadLine();
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Equals(shapeMatch)) // finds all indexes that match user input
                {
                    Console.WriteLine(i); // prints indexes that match input                 
                }
            }
            if (!shapes.Contains(shapeMatch)) // if user input does not exist in list message informing user is printed 
            {
                Console.WriteLine("This input does not exist inside this list");
            }

            //Part 6

            Console.WriteLine("\n");

            List<string> colors = new List<string>() { "red", "blue", "red", "green", "red", "blue" }; // this is a list of colors
            List<string> singles = new List<string>(); //This is a blank list to be populated
            List<string> duplicates = new List<string>(); //This is a blank list to be populated

            foreach (string color in colors) // this foreach loop evluates each item in colors
            {
                if (!singles.Contains(color)) // as this foreach iterates through it checks to see if the item is "NOT" in the singles list
                {
                    singles.Add(color);// if it is "NOT" it adds the item to the list
                    Console.WriteLine(color + ": This is unique"); // prints color and message
                }
                else
                {
                    duplicates.Add(color); // when the foreach loop interates to an item thats already present in the singles list being created it adds those items to the duplicates list
                    Console.WriteLine(color + ": This is a duplicate"); // prints color and message
                }
            }
            Console.ReadLine();

        }
    }
}
