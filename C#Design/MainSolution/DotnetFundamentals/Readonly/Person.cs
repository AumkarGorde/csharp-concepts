using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFundamentals.Readonly
{
    public class Person
    {
        public readonly string FirstName;
        public readonly string LastName;
        public readonly DateTime DateOfBirth;

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Date of Birth: {DateOfBirth:d}");
        }
    }

}
