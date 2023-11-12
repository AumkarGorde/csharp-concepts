using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Inheritance
{
    // Base class
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    // Derived class
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }
}
