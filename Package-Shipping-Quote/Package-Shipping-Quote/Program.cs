using System;


namespace Package_Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express\n");//Prints string
            Console.WriteLine("What is the package weight?");//Prints string
            int pckgWeight = Convert.ToInt32(Console.ReadLine());//converts string to integer data type for future mathmatical operations

            if (pckgWeight > 50) // checks if Weight is to heavy to be shipped and if so terminates, if elligible moves on to next steps
            {
                Console.WriteLine("Package too heavy to shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("\nWhat is the package width?");
                int pckgWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nWhat is the package height?");
                int pckgHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nWhat is the package length?");
                int pckgLength = Convert.ToInt32(Console.ReadLine());

                int Dimensions = pckgWidth + pckgHeight + pckgLength;
                int total = pckgWidth * pckgHeight * pckgLength * pckgWeight / 100;

                if (Dimensions > 50) // Checks to see if package is to large to ship if not it calculates and displays the shipping price
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                }
                else
                {
                    Console.WriteLine("\nYour estimated total for shipping this package is: $" + total.ToString() + ".00" + "\nThank You!");
                }  
            }
            Console.ReadLine();
        }
    }
}