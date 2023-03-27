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
        int a, b,first,second;
        public Constructor2(int a, int b)
        {
			this.first = a;
			this.second = b;
        }
        public void Multi()
        {
            int sum = first * second;
            Console.WriteLine(sum);
        }

    }
}

