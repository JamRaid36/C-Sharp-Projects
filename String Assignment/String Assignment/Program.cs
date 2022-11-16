using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineA = "Hey there, ";
            string lineB = "What's ";
            string lineC = "up?";

            Console.WriteLine(lineA + lineB + lineC);

            string name = "Jason";

            name = name.ToUpper();
            Console.WriteLine(name);

            StringBuilder sb = new StringBuilder();

            sb.Append("This is the start of a paragraph. ");
            sb.Append("\nThis paragraph is being built");
            sb.Append(" one line at a time.");
            sb.Append(" \nThis will be the last line of this paragraph.");


            Console.WriteLine(sb);

            Console.ReadLine();

        }
    }
}
