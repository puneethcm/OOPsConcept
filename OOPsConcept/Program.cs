using OOPsConcept;
using static OOPsConcept.OverRiding;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to OOPs Concept");

        //Car car = new Car();
        //Console.WriteLine("Car barnd is " + car.brand);
        //car.Type();
        //car.Color = "red";
        //car.CarProperties(800000, "Vento");

        //OverLoading overLoading = new OverLoading();
        //Console.WriteLine(overLoading.Add(5, 7));
        //Console.WriteLine(overLoading.Add(5.5f, 7.6f));
        //overLoading.Add(4, 5.5f, 9);

        Animal animal = new Animal();
        Animal cow = new Cow();
        animal.AnimalTypes();
        cow.AnimalTypes();
        Console.ReadLine();
    }
}