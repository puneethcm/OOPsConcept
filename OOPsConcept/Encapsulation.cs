using System;
namespace OOPsConcept
{
	public class Encapsulation
	{
		private string name;
		public int Id;

		public Encapsulation(string name)
		{
			this.name = name;
		}

        public string GetName()
		{
			return name;
		}
	}
}

