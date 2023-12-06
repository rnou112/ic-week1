using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareDev_Week1.Interfaces;

namespace SoftwareDev_Week1.Classes
{
    public class Apple : IFruit
    {
        public string GetColor()
        {
            return "Red or Green";
        }
    }
    public class Orange : IFruit
    {
        public string GetColor()
        {
            return "Orange";
        }
    }
}
