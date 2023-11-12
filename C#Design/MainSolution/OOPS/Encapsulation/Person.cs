using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Encapsulation
{
    public class Person
    {
        // Private fields (data)
        private string name;
        private int age;

        // Public properties to provide controlled access to the private fields
        public string Name
        {
            get { return name; }
            set
            {
                // Validation can be added here
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty.");
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                // Validation can be added here
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be negative.");
                }
            }
        }

        // Public method to provide controlled access to the encapsulated data
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
