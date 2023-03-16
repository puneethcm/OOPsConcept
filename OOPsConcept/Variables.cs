using System;
namespace OOPsConcept
{
	public class Variables
	{
		const int a = 20;  // constant variable with fixed value
		const int b = 10;
		public void Add()
		{
			int result; // local variable
			result = a + b;
			Console.WriteLine("Result" + result);
		}

		static string place = "Banglore";
		public static void Places()
		{
			Console.WriteLine("I live in " + place);
		}
	}
}

