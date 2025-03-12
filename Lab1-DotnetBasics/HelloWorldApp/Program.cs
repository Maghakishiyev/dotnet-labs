using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for their name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Greet the user with a fun fact message
            Console.WriteLine("Hello, " + name + "! Did you know I love coding?");
        }
    }
}