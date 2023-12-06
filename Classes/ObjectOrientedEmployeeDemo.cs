using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDev_Week1.Classes
{
    public class ObjectOrientedEmployeeDemo
    {
        public float BaseSalary = 300;
        public float OverTime = 10;
        public float Rate = 10;

        public float GetWage()
        {
            return BaseSalary + OverTime * Rate;
        }
    }
}
