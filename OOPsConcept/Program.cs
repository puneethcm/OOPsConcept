using OOPsConcept;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to OOPs Concept");

        Car car = new Car();
        Console.WriteLine("Car barnd is " + car.brand);
        car.Type();
        car.Color = "red";
        car.CarProperties(800000, "Vento");
        Console.ReadLine();
    }
}