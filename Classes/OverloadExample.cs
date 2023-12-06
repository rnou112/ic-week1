using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDev_Week1.Classes
{
    class OverloadExample
    {
        // method with one parameter
        public void display(int a)
        {
            Console.WriteLine("Arguments 1 integer: " + a);
        }

        // method with two parameters
        public void display(int a, int b)
        {
            Console.WriteLine("Arguments 2 integers: " + a + " and " + b);
        }

        // method with two parameters
        public void display(int a, string b)
        {
            Console.WriteLine("Arguments: " + a + " and " + b);
        }

        // method with two parameters
        public void display(string a, int b)
        {
            Console.WriteLine("Arguments: " + a + " and " + b);
        }
    }
}
