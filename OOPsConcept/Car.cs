using System;
namespace OOPsConcept
{
	public class Car
	{
		public string Color;
		public void CarProperties(int price, string model)
		{
			Console.WriteLine("Car colour is " + Color);
			Console.WriteLine( model + " car price is " + price);
		}
	}
}

