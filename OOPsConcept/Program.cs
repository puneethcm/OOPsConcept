using OOPsConcept;
using static OOPsConcept.TypesOfInheritance;
using static OOPsConcept.TypesOfInheritance.ClassB;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to OOPs Concept");
        Console.WriteLine("Choose Type of Inheritance \n1:single Inheritance\n2:Hierarchical Inhritance\n3:MultiLevel Inheritance ");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Car car = new Car();
                Console.WriteLine("Car barnd is " + car.brand);
                car.Type();
                car.Color = "red";
                car.CarProperties(800000, "Vento");
                break;
            case 2:
                ClassA classA = new ClassA();
                Console.WriteLine(classA.msg());
                ClassB classB = new ClassB();
                Console.WriteLine(classA.msg());
                Console.WriteLine(classB.info());
                ClassC classC = new ClassC();
                Console.WriteLine(classA.msg());
                Console.WriteLine(classC.getinfo());
                break;
            case 3:
                Animal animal = new Animal();
                animal.animal();
                break;
        }
        Console.ReadLine();
    }
}