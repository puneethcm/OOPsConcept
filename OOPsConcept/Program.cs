using OOPsConcept;
using static OOPsConcept.Abstraction;
using static OOPsConcept.OverRiding;
using static OOPsConcept.ValueAndReferenceType;
using static OOPsConcept.TypesOfInheritance;
using static OOPsConcept.TypesOfInheritance.ClassB;
using static OOPsConcept.Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to OOPs Concept");
        Console.WriteLine("\n1:Object and Class\n2:Inheritance\n3:Polymorphism\n4:Encapsulation" +
            "\n5:Abstraction\n6:Variables\n7:Types of method\n8:Value and Reference type\n9:Delete array element\n10:Interface" +
            "\n11:Constructor");
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
                Encapsulation encapsulation = new Encapsulation("Puneeth");
                encapsulation.Id = 1050;
                Console.WriteLine("Employee Id " + encapsulation.Id + " Name " + encapsulation.GetName());
                break;
            case 5:
                EmployeeDetails employeeDetails = new EmployeeDetails();
                employeeDetails.EmployeeName();
                Console.WriteLine(employeeDetails.EmployeeSalary());
                break;
            case 6:
                Variables variables = new Variables();
                variables.Add();
                Variables.Places();
                Variables.diffrence();
                break;
            case 7:
                TypesOfMethods methods = new TypesOfMethods();
                methods.Person();
                methods.PersonName("Abhishek");
                Console.WriteLine(methods.Multiply(5, 4));
                TypesOfMethods.Car();
                TypesOfMethods.PersonLastName("Karthik");
                break;
            case 8:
                int i = 10;
                Console.WriteLine(i);
                ValueAndReferenceType.ValueType.ChangeValue(i);
                Console.WriteLine(i);

                ValueAndReferenceType value = new ValueAndReferenceType();
                Student std2 = new Student();
                std2.Name = "Lucky";
                Console.WriteLine("Before change " + std2.Name);
                ValueAndReferenceType.ReferenceType.ChangeReferenceValue(std2);
                Console.WriteLine("After change " + std2.Name);
                break;
            case 9:
                Console.WriteLine("Enter the elements to add in array");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];
                Console.WriteLine("Please enter element one by one");
                for(int a=0; a < arr.Length; a++)
                {
                    arr[a] = Convert.ToInt32(Console.ReadLine());
                    Console.Write(arr[a]+" ");
                }
                Console.WriteLine("Pick one element you want to delete");
                int delete = Convert.ToInt32(Console.ReadLine());
                DeletElement.DeleteElement(arr,delete);
                break;
            case 10:
                Emp employee = new Emp();
                employee.Name();
                employee.Salary();
                break;
            case 11:
                Constructor constructor = new Constructor();
                constructor.Addd();

                Constructor2 constructor2 = new Constructor2();
                constructor2.Multi();
                break;

        }
        Console.ReadLine();
    }
}