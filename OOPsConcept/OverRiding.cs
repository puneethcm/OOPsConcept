using System;
namespace OOPsConcept
{
	public class OverRiding
	{
		public class Animal
		{
			public virtual void AnimalTypes()
			{
				Console.WriteLine("Lion is Carnivorous");
			}
		}

		public class Cow : Animal
		{
			public override void AnimalTypes()
			{
				Console.WriteLine("Cow is Herbivorous");
			}
		}
	}
}

