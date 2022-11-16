using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Submission_Assignment
{
    class Math
    {
       

        //Below are 3 Math overload methods that take in different data types perform math operations and return 

        
        public int Operation(int x) // this takes in an integer performs a math operation and returns an integer
        {
            int answer = x + 10;
            return answer;
        }

        public int Operation(double x) // this takes in an decimal, converts it to an integer, performs a math operation and returns an integer
        {
            int y = Convert.ToInt32(x);
            int answer = y - 1;
            return answer;
        }

        public int Operation(string x) // this takes in an string, converts it to an integer, performs a math operation and returns an integer
        {
            int y = Convert.ToInt32(x);
            int answer = y + 5;
            return answer;
        }


    }
}
