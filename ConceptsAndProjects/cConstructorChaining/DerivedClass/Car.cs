using System;
using System.Collections.Generic;
using System.Text;

namespace cConstructorChaining
{
    public class Car : Vehicle
    {
        public string Model { get; }

        public Car(string type, int year, string model) : base(type, year)
        {
            Model = model;
        }
    }
}
