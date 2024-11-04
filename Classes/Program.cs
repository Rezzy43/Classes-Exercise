public class Car
{
    // Properties
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // I'm creating a new instance of the Car class
        Car myCar = new Car();
        
        // Setting values in the properties
        myCar.Make = "Toyota";
        myCar.Model = "Supra";
        myCar.Year = 2025;
        
        // Printing the values of each property to the console
        Console.WriteLine($"Make: {myCar.Make}");
        Console.WriteLine($"Model: {myCar.Model}");
        Console.WriteLine($"Year: {myCar.Year}");
    }
}