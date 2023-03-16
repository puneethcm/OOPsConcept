using System;
namespace OOPsConcept
{
	public class TypesOfMethods
	{
		//intstance method or normal method
		// without parameter
		public void Person()
		{
			Console.WriteLine("Puneeth");
		}
		// with parameter
        public void PersonName(string name)
        {
            Console.WriteLine(name);
        }

		// static method without parameter
		public static void Car()
		{
			Console.WriteLine("Vento");
		}
		// with parameter and return value
		public static void PersonLastName(string firstName,string lastName = "Kumar")
		{
			Console.WriteLine(firstName + " " + lastName);
		}
		// return value method
		public int Multiply(int a, int b)
		{
			return a * b;
		}
    }
}

