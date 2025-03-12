using System;

namespace DataTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operators
            int a = 10;
            int b = 5;
            Console.WriteLine("Addition (a + b): " + (a + b));
            Console.WriteLine("Multiplication (a * b): " + (a * b));

            // Comparison Operators
            bool isEqual = (a == b);
            Console.WriteLine("Are a and b equal? " + isEqual);

            // Logical Operators
            bool condition = (a > b) && (b > 0);
            Console.WriteLine("Is a greater than b and b greater than 0? " + condition);

            // Data types example: double and string
            double pi = 3.14159;
            string message = "The value of pi is approximately ";
            Console.WriteLine(message + pi);

            // --- Additional Experiments ---
            // 1. Declare an additional boolean variable.
            bool isPositive = a > 0;
            Console.WriteLine("Is 'a' positive? " + isPositive);

            // 2. Perform a new arithmetic operation using another int variable.
            int c = 3;
            int subtractionResult = a - c;
            Console.WriteLine("Subtraction (a - c): " + subtractionResult);

            // 3. Create a string that concatenates text with a number.
            string concatenatedMessage = "Subtracting " + c + " from " + a + " gives " + subtractionResult;
            Console.WriteLine(concatenatedMessage);
        }
    }
}