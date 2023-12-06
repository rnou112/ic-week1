using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDev_Week1.Classes
{

    public class BaseClass
    {
        public virtual void display()
        {
            Console.WriteLine("Base class display method ");
        }
    }

    public class OverrideExample : BaseClass
    {
        public override void display()
        {
            Console.WriteLine("Derived class display method ");
        }
    } 
}
