using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDev_Week1.Classes
{
    // A base class
    public class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Description { get;} = "My description";

    
        public void Eat()
        {
            Console.WriteLine(Name + " is eating." + Description);
        }

    }

    // A derived class that inherits from Animal
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine(Name + " is barking.");
        }
    }
}
    