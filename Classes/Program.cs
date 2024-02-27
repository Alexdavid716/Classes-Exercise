using System;

// Define the public Car class
public class Car
{
    // Public properties
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Car class
        Car myCar = new Car();

        // Set values in the properties for the object
        myCar.Make = "Toyota";
        myCar.Model = "Camry";
        myCar.Year = 2020;

        // Print the values of each property to the Console
        Console.WriteLine($"Make: {myCar.Make}");
        Console.WriteLine($"Model: {myCar.Model}");
        Console.WriteLine($"Year: {myCar.Year}");
    }
}