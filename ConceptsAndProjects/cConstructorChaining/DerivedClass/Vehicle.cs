using System;
using System.Collections.Generic;
using System.Text;

namespace cConstructorChaining
{
    public class Vehicle
    {
        public string Type { get; }
        public int Year { get; }

        public Vehicle(string type, int year)
        {
            Type = type;
            Year = year;
        }
    }
}
