using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFundamentals.ConstructorChaining
{
    // Base class representing a generic vehicle
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        // Default constructor
        public Vehicle() : this("Unknown Make", "Unknown Model")
        {
        }

        // Parameterized constructor
        public Vehicle(string make, string model)
        {
            Make = make;
            Model = model;
        }

        // Method to display vehicle information
        public void DisplayInfo()
        {
            Console.WriteLine($"Base : Make: {Make}, Model: {Model}");
        }
    }

    // Derived class representing a car
    public class Car : Vehicle
    {
        public int NumDoors { get; set; }

        // Default constructor
        public Car() : this("Unknown Make", "Unknown Model", 4)
        {
        }

        // Parameterized constructor
        public Car(string make, string model, int numDoors) : base(make, model)
        {
            NumDoors = numDoors;
        }

        // Method to display car information
        public void DisplayCarInfo()
        {
            DisplayInfo(); // Call base class method to display common information
            Console.WriteLine($"Number of Doors: {NumDoors}");
        }
    }

    // Derived class representing a motorcycle
    public class Motorcycle : Vehicle
    {
        public bool HasFairing { get; set; }

        // Default constructor
        public Motorcycle() : this("Unknown Make", "Unknown Model", false)
        {
        }

        // Parameterized constructor
        public Motorcycle(string make, string model, bool hasFairing) : base(make, model)
        {
            HasFairing = hasFairing;
        }

        // Method to display motorcycle information
        public void DisplayMotorcycleInfo()
        {
            DisplayInfo(); // Call base class method to display common information
            Console.WriteLine($"Has Fairing: {HasFairing}");
        }
    }
}
