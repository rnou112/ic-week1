using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDev_Week1.Classes
{
    class EvenOddNumbers
    {
        public void NumberCheck()
        {
            Console.WriteLine("Enter Number of your choice - >");
            int Number = Convert.ToInt32(Console.ReadLine());

            switch (Number % 2)
            {
                case 0:     
                    Console.WriteLine("Number is 0"); 
                    break;
                case 1:
                    Console.WriteLine("Number is Odd");
                    break;
            }
        }
    }
}
