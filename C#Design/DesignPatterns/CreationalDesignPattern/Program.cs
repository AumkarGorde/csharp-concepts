using CreationalDesignPattern.Singleton;

Console.WriteLine("Singleton Pattern");
ConfigurationManager instance = ConfigurationManager.Instance;
string con = instance.GetSetting("ConnectionString");
Console.WriteLine($"Value is : {con}");

ConfigurationManager instance2 = ConfigurationManager.Instance;
string con1 = instance.GetSetting("LogLevel");
Console.WriteLine($"Value is : {con1}");

Console.ReadKey();
