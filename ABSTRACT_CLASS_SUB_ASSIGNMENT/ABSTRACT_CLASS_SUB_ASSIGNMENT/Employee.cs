using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUB_ASSIGNMENT
{
    
    public class Employee : Person //Created class that inherits properties and vuertual SayName method from Abstract Person class 
    {
        public override void SayName()
        {
            base.SayName();
        }
    }
    
}
