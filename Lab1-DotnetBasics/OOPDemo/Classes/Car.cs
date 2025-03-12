using System;

namespace OOPDemo.Classes
{
    public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        
        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }
        
        public void DisplayDetails()
        {
            Console.WriteLine($"Car Model: {Model}, Year: {Year}");
        }
    }
}