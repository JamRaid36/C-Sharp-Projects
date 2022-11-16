using System;
using System.Collections.Generic;


namespace ConsoleAppArraySubmisionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            //Creates an string array and asks user to select an index
            string[] nameArray2 = {"Jason", "John", "Jim", "Jane", "Janice"};
            Console.WriteLine("Please select an index between 0 and 4");
            int name = Convert.ToInt32(Console.ReadLine());//converts user string selection to integer
            if(name > nameArray2.Length)// if selection is greater than 4 an error message is read and program ends, if selection is less than 4 user may proceed
            {
                Console.WriteLine("This index does not exist!");
            }
            else
            {
                Console.WriteLine(nameArray2[name]); //Prints user index selection
                int[] numArray = { 1, 10, 100, 1000, 10000 }; //Creates an integer array 
                Console.WriteLine("Please select an index between 0 and 4");//asks user to select an index
                int num = Convert.ToInt32(Console.ReadLine()); //converts user string selection to integer
                if (num > numArray.Length)// if selection is greater than available indexes in array an error message is read and program ends, if selection is one of the available indexes user may proceed
                {
                    Console.WriteLine("This index does not exist!");
                }
                else
                {
                    Console.WriteLine(numArray[num]); //Prints user index selection
                    List<string> stringList = new List<string>(); //Creates a list of strings 
                    stringList.Add("Boat");
                    stringList.Add("Truck");
                    stringList.Add("Plane");
                    stringList.Add("Train");
                    Console.WriteLine("Please select an index between 0 and 3"); //asks user to select an index
                    int vehicles = Convert.ToInt32(Console.ReadLine()); //converts user string selection to integer
                    if (vehicles > stringList.Count) //if if selection is greater than available indexes in list an error message is read and program ends, if selection is one of the available indexes user may proceed
                    {
                        Console.WriteLine("This index does not exist!");
                    }
                    else
                    {
                        Console.WriteLine(stringList[vehicles]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
