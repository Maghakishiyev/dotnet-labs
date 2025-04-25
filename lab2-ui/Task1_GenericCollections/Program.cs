using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> cities = new List<string> { "Warsaw", "Krakow", "Gdansk" };
        cities.Add("Lodz");

        Console.WriteLine("List of cities:");
        foreach (var city in cities)
        {
            Console.WriteLine("- " + city);
        }

        Dictionary<string, int> population = new Dictionary<string, int>
        {
            { "Warsaw", 1800000 },
            { "Krakow", 770000 }
        };

        Console.WriteLine();
        Console.WriteLine("Population of Warsaw: " + population["Warsaw"]);
    }
}