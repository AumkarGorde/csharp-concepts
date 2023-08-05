using System;

namespace ExceptionHandler
{
    public class CustomBaseException : Exception
    {
        public ErrorCode ErrorCode { get; set; }
        public string ErrorDetails { get; set; }
        public CustomBaseException()
        {
        }

        public CustomBaseException(string message) : base(message)
        {
        }
        public CustomBaseException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    /* Identify Common Exception Types: 
     1. Identify Common Exception Types:
        - Start by identifying the types of errors or exceptional situations that are likely to occur across different applications. 
        - Consider factors such as data validation, business rules, external dependencies, and unexpected failures.
     2. Create a Base Custom Exception:
        - You can name this exception class specific to your application
        - Define a base custom exception class that extends the Exception class. 
        - This base exception can serve as the foundation for your custom exception hierarchy.
    3. Define Specific Exception Classes:
        - Create specific exception classes that inherit from your base CustomException class. 
        - Each specific exception class should represent a distinct type of error or exceptional scenario.
    4. Include Additional Information:
        - Add properties or fields to your specific exception classes to include additional information relevant to the specific type of error. 
        - This could include error codes, error details, data related to the exception, etc.
    5. Throw Custom Exceptions:
        - In your application code, when you encounter an error or exceptional scenario, throw the appropriate custom exception.
    6. Catch and Handle Custom Exceptions:
        - Implement exception handling in your application to catch and handle your custom exceptions. 
        - You can catch specific exceptions and take appropriate actions based on the exception type.
    7. Documentation and Guidelines:
        - Provide clear documentation and guidelines for using your custom exceptions. 
        - Explain the purpose of each exception type and when they should be used. This will help developers understand how to handle and respond to different exceptional situations.
     */
}
