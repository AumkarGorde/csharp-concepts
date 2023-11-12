// See https://aka.ms/new-console-template for more information

// Creating instances using different constructors

using DotnetFundamentals.ConstructorChaining;
using DotnetFundamentals.Readonly;
using DotnetFundamentals.StaticConstructor;

Car myCar = new Car("Toyota", "Camry", 4);
myCar.DisplayCarInfo();

Console.WriteLine();

Car myCar1 = new Car();
myCar1.DisplayCarInfo();

Console.WriteLine();

Motorcycle myMotorcycle = new Motorcycle("Harley-Davidson", "Sportster", true);
myMotorcycle.DisplayMotorcycleInfo();

Console.WriteLine();

// Access the ConfigurationManager to demonstrate configuration loading
var s = new ConfigurationManager(); //In this case both static and non-static constructor are called. First static then non-static
string serverAddress = ConfigurationManager.GetSetting("ServerAddress"); // In this only static constructor is called 
string pass = ConfigurationManager.GetSetting("Password"); // here static constructor is not called as it is already called earlier

// Perform other operations using the configuration settings
if (serverAddress != null)
{
    Console.WriteLine($"Connected to server at {serverAddress} , {pass}");
}

Console.WriteLine();

// Create a person
Person johnDoe = new Person("John", "Doe", new DateTime(1990, 5, 15));

// Display information
johnDoe.DisplayInfo();

// Attempting to modify the readonly fields results in a compilation error
// johnDoe.FirstName = "Jane"; // Error: 'Person.FirstName' is readonly - Compile Time error


Console.WriteLine("Hello, World!");
