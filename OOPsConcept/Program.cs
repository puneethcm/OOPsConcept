using OOPsConcept;
using static OOPsConcept.Abstraction;
using static OOPsConcept.OverRiding;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to OOPs Concept");
        Console.WriteLine("\n1:Object and Class\n2:Inheritance\n3:Polymorphism\n4:Encapsulation\n5:Encapsulation" +
            "\n6:Abstraction");
        int options = Convert.ToInt32(Console.ReadLine());

        switch (options)
        {
            case 1:
                Vehicle vehicle = new Vehicle();
                Console.WriteLine("Car barnd is " + vehicle.brand);
                vehicle.Type();
                vehicle.brand = "Volks Wagen";
                break;
            case 2:
                Car car = new Car();
                Console.WriteLine("Car barnd is " + car.brand);
                car.Type();
                car.Color = "red";
                car.CarProperties(800000, "Vento");
                break;
            case 3:
                OverLoading overLoading = new OverLoading();
                Console.WriteLine(overLoading.Add(5, 7));
                Console.WriteLine(overLoading.Add(5.5f, 7.6f));
                overLoading.Add(4, 5.5f, 9);
                break;
            case 4:
                Animal animal = new Animal();
                Animal cow = new Cow();
                animal.AnimalTypes();
                cow.AnimalTypes();
                break;
            case 5:
                Encapsulation encapsulation = new Encapsulation("Puneeth");
                encapsulation.Id = 1050;
                Console.WriteLine("Employee Id "+ encapsulation.Id + " Name " + encapsulation.GetName());
                break;
            case 6:
                EmployeeDetails employeeDetails = new EmployeeDetails();
                employeeDetails.EmployeeName();
                Console.WriteLine(employeeDetails.EmployeeSalary());
                break;

        }
        Console.ReadLine();
    }
}