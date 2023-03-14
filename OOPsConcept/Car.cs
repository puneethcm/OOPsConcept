using System;
namespace OOPsConcept
{
	public class Vehicle
	{
		public string brand = "Volks Wagen";

		public void Type()
		{
			Console.WriteLine("Petrol");
		}
	}

    public class Car : Vehicle
    {
        public string Color;
        public void CarProperties(int price, string model)
        {
            Console.WriteLine("Car colour is " + Color);
            Console.WriteLine(model + " car price is " + price);
        }
    }
}

