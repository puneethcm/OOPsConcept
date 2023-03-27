using System;
namespace OOPsConcept
{
	public class Constructor
	{
		int a, b;
		public Constructor()
		{
			a = 100;
			b = 150;
		}
		public void Addd()
		{
			int sum = a + b;
			Console.WriteLine(sum);
		}

	}
    public class Constructor2
    {
        string first,last;
        public Constructor2(string first, string last)
        {
			this.first = first;
			this.last = last;
        }
        public void Name()
        {
            Console.WriteLine("First Name: "+ first +"Last Name: "+ last);
        }

    }
}

