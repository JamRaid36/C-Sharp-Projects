using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_CLASS_SUB_ASSIGNMENT_VOID_METHOD
{
    class Program
    {
        static void Main(string[] args)
        {
            CSA csa1 = new CSA(); // Instantiates object
            csa1.VMeth(10,20); //calling void method
            csa1.VMeth(p2: 35, p1: 5);// calling void method with named parameters
            Console.ReadLine();
        }
        
    }
}
