using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Submission_Assignment
{
    public class UserMath // Creates the UserMath class
    {
        public int UserNum { get; set; } //This is a property of UserMath

        //Below are 3 UserMath methods that perform different math operations

        //This adds 10 to UserNum selected by User
        public int AddTen()
        {
            return UserNum + 10;
        }
        //This divides UserNum by 2
        public int DivideByTwo()
        {
            return UserNum / 2;
        }

        //This multiplies UserNum by 2
        public int MultiplyByTwo()
        {
            return UserNum * 2;
        }

    }
}
