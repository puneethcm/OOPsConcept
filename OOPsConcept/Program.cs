using OOPsConcept;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to OOPs Concept");

        Car car = new Car();
        car.Color = "red";
        car.CarProperties(8000, "VolksVagen");
        Console.ReadLine();
    }
}