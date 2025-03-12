using System;
using OOPDemo.Classes; // Import the classes from the Classes folder

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and display Person objects
            Person person1 = new Person("Movsum", 23);
            person1.DisplayInfo();
            
            Person person2 = new Person("Mason", 32);
            person2.DisplayInfo();
            
            // Create and display Car objects
            Car car1 = new Car("Toyota Camry", 2018);
            car1.DisplayDetails();
            
            Car car2 = new Car("Lada 2107", 1999);
            car2.DisplayDetails();
        }
    }
}