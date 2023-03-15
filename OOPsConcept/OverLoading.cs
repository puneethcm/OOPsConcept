using System;
namespace OOPsConcept
{
	public class OverLoading
	{
		public int Add(int a, int b)
		{
			int sum;
            sum = a + b;
			return sum;
		}
        public float Add(float a, float b)
        {
            float sum;
            sum = a + b;
            return sum;
        }
        public void Add(int a, float b, int c)
        {
            Console.WriteLine("First number "+ a + " second number " + b + "Third number " + c);
        }
    }
}

