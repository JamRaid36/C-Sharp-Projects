using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission_Assignment
{
    public class User
    {
       //Properties of user
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string UserName) :this(UserName, "Password")//Constructor with default password string chained
        {

        }
       
        public User(string UserName, string Password)  //main constructor
        {
            this.UserName = UserName;
            this.Password = Password;
        }

       

    }
}
