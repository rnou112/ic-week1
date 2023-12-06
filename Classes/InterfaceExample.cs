using SoftwareDev_Week1.Interfaces;

namespace SoftwareDev_Week1.Classes
{
    public class InterfaceExample : IInterfaceTest
    {

        public string Name
        {
            get
            {
                return "Name of class that implements the Interface";
            }
        }
    }
}