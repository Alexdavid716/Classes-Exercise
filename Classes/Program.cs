using System;


public class Car
{
 
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        
        Car myCar = new Car();

        
        myCar.Make = "Toyota";
        myCar.Model = "Camry";
        myCar.Year = 2020;

        
        Console.WriteLine($"Make: {myCar.Make}");
        Console.WriteLine($"Model: {myCar.Model}");
        Console.WriteLine($"Year: {myCar.Year}");
    }
}