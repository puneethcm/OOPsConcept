using System;
namespace OOPsConcept
{
	public class Interface
	{
		interface IPerson
		{
			void Name();
			void Salary();
		}
		public class Emp : IPerson
        {
			public void Name()
			{
				Console.WriteLine("Puneeth");
			}
			public void Salary()
			{
				Console.WriteLine("500000");
			}
		}

    }
}

