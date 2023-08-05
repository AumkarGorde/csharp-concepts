using cConstructorChaining;
using ExceptionHandler;
using System;

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
                int a = 3;
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

            #endregion
        }
    }
}
