using FinalProject.Classes;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get user input - Name, Age
            Console.Write("Enter your name: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter your age: ");
            int age;
            while (!int.TryParse(Console.ReadLine()!, out age))
            {
                Console.Write("Invalid input. Please enter a valid age: ");
            }

            // Display user profile by creating new instance of UserProfile class
            UserProfile user = new UserProfile(name, age);
            user.DisplayProfile();

            // Display message based on user age
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }

            // 
            Console.WriteLine("Displaying numbers from 1 to user age:");
            for (int i = 1; i <= age; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            PerformArithmeticOperation();

            // Give user multipleChoices and handle cases
            Console.WriteLine("Select an option: 1 - Greet, 2 - Display Profile, 3 - Exit");
            int option;
            while (!int.TryParse(Console.ReadLine()!, out option))
            {
                Console.WriteLine("Invalid input. Please select a valid option: ");
            }

            switch (option)
            {
                case 1:
                    Console.WriteLine($"Hello, {name}! Hope you have a great day!");
                    break;
                case 2:
                    user.DisplayProfile();
                    break;
                case 3:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }

            // Using a loop allow users to execute arithmeticOperations
            Console.WriteLine("Would you like to perform another arithmetic operation? (yes/no)");
            string response = Console.ReadLine()!.ToLower();
            while (response == "yes")
            {
                PerformArithmeticOperation();
                Console.WriteLine("Perform another operation? (yes/no)");
                response = Console.ReadLine()!.ToLower();
            }

            Console.WriteLine("Final Project Completed. Press any key to exit.");
            Console.ReadKey();
        }

        static void PerformArithmeticOperation()
        {
            Console.Write("Enter the first number for arithmetic operations: ");
            int num1;
            while (!int.TryParse(Console.ReadLine()!, out num1))
            {
                Console.Write("Invalid input. Enter a valid number: ");
            }

            Console.Write("Enter the second number: ");

            int num2;

            while (!int.TryParse(Console.ReadLine()!, out num2))
            {
                Console.Write("Invalid input. Enter a valid number: ");
            }

            Console.WriteLine("Select an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            int op;

            while (!int.TryParse(Console.ReadLine()!, out op) || op < 1 || op > 4)
            {
                Console.Write("Invalid input. Please select a valid option (1-4): ");
            }

            switch (op)
            {
                case 1:
                    int sum = num1 + num2;
                    Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");
                    break;
                case 2:
                    int difference = num1 - num2;
                    Console.WriteLine($"Difference of {num1} and {num2} is: {difference}");
                    break;
                case 3:
                    int product = num1 * num2;
                    Console.WriteLine($"Product of {num1} and {num2} is: {product}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        double quotient = (double)num1 / num2;
                        Console.WriteLine($"Quotient of {num1} divided by {num2} is: {quotient}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero!");
                    }
                    break;
            }
        }
    }
}