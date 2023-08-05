using ApplicationLogger;
using cConstructorChaining;
using ExceptionHandler;
using Microsoft.Extensions.DependencyInjection;
using ParallelExecution;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProgramRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constructor Chaining
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("********************************Consrtuctor Chaining*******************************************");
            Console.WriteLine("**********************************************************************************************");
            /*Consrtuctor Chaining*/
            Product defaultProduct = new Product();
            Product headphone = new Product("HeadPhone");
            Product smartphone = new Product("Smartphone", 499.99);
            Product laptop = new Product("Laptop", 899.99, 10);

            Console.WriteLine($"Default Product: {defaultProduct.Name}, Price: {defaultProduct.Price}, Stock: {defaultProduct.QuantityInStock}");
            Console.WriteLine($"Headphone: {headphone.Name}, Price: {headphone.Price}, Stock: {headphone.QuantityInStock}");
            Console.WriteLine($"Smartphone: {smartphone.Name}, Price: {smartphone.Price}, Stock: {smartphone.QuantityInStock}");
            Console.WriteLine($"Laptop: {laptop.Name}, Price: {laptop.Price}, Stock: {laptop.QuantityInStock}");

            Car myCar = new Car("Sedan", 2022, "Toyota Corolla");

            Console.WriteLine($"Type: {myCar.Type}");
            Console.WriteLine($"Year: {myCar.Year}");
            Console.WriteLine($"Model: {myCar.Model}");

            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("*********************************Exception Handling*******************************************");
            Console.WriteLine("**********************************************************************************************");
            #endregion
            #region Exception Handling
            try
            {
                int a = 1;
                if (a == 1)
                    throw new ApplicationDependencyException(ErrorCode.HTTP_FAILURE, "HTTP Failure");
                else if (a == 2)
                    throw new ApplicationDependencyException(ErrorCode.FTP_FAILURE, "FTP Error", new { Reason = "Some Issue in File"});
                else if (a == 3)
                {
                    var b = a / 0;
                }
            }
            catch (Exception ex)
            {
                if(ex is ApplicationDependencyException)
                {
                    var exobj = ex as ApplicationDependencyException;
                    Console.WriteLine($"Demonstration Complete !!, ErrorCode = {exobj.ErrorCode}, " +
                        $"ErrorDetails = {exobj.ErrorDetails}, ErrorData = {exobj.ErrorData}");
                }
                else
                    throw new ApplicationDependencyException(ErrorCode.UNKOWN_ERROR, ex.Message, new { Reason = "Just a demonstration"}, ex);
            }
            #endregion

            #region Application Logging
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("*********************************Application Logging*******************************************");
            Console.WriteLine("***********************************************************************************************");
            
            // Create a service collection and configure the custom logger
            var services = new ServiceCollection()
                .AddCustomLogger(LogProvider.SeriLog, logFileName:"customlogFile.log") // Use your AddCustomLogger extension method
                .BuildServiceProvider();

            // Get an instance of ICustomLogger
            var _logger = services.GetRequiredService<ICustomLogger>();

            // Log using the custom logger
            _logger.LogInformation("Hello, Custom Logger!");
            _logger.LogInformation("How Are you ?");
            _logger.LogInformation("Logs are added !!");
            _logger.LogError("Some Error !!" , new Exception("Test"));
            _logger.LogWarning("Warning Logs !!");

            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("*********************************Application Logging*******************************************");
            Console.WriteLine("***********************************************************************************************");
            #endregion

            #region

            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("*****************************************Parallel Execution***********************************");
            Console.WriteLine("**********************************************************************************************");

            var list = new List<string>
                      {
                          "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis",
                          "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson",
                          "Thomas", "Taylor", "Moore", "Jackson", "Martin", "Lee", "Perez", "Thompson",
                          "White", "Harris", "Sanchez", "Clark", "Ramirez", "Lewis", "Robinson", "Walker",
                          "Young", "Allen", "King", "Wright", "Scott", "Torres", "Nguyen", "Hill", "Adams",
                          "Nelson", "Baker", "Hall", "Rivera", "Campbell", "Mitchell", "Carter", "Rob   erts",
                          "Gomez", "Phillips", "Evans", "Turner", "Diaz", "Parker", "Cruz", "Edwards",
                          "Collins", "Reyes", "Stewart", "Morris", "Morales", "Murphy", "Cook", "Rogers",
                          "Morgan", "Peterson", "Cooper", "Reed", "Bailey", "Bell", "Gonzales", "Reyes",
                          "Foster", "Smith", "Johnson"
                      };

            Stopwatch sp = new Stopwatch();
            sp.Start();
            //foreach (var name in list)
            //{
            //    HelperClass.CreateFile($"Result\\{name}", $"{name}_file");
            //}

            /*We use Parallel.ForEach with Partitioner.
             * Create to divide the work into batches. 
             * The Partitioner.Create method creates a partitioner that defines the ranges for each batch. 
             * The range variable represents the range of indices for the current batch.*/
            Parallel.ForEach(Partitioner.Create(0, list.Count, 5), Range =>
            {
                for (int i = Range.Item1; i < Range.Item2; i++)
                {
                    string name = list[i];
                    Console.WriteLine($"Processing {name} on thread {Task.CurrentId}");
                    HelperClass.CreateFile($"Result\\{name}", $"{name}_file");
                }
            });

            sp.Stop();
            Console.WriteLine($"Time taken : {sp.Elapsed.TotalSeconds} sec");
            #endregion
        }
    }
}
