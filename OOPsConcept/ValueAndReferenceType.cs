using System;
namespace OOPsConcept
{
	public class ValueAndReferenceType
	{
		public class ValueType
		{
			public static void ChangeValue(int x)
			{
				x = 20;
				Console.WriteLine(x);
			}
		}

		public class Student
		{
			public string Name
			{ get; set; }
		}

		public class ReferenceType
		{
			public static void ChangeReferenceValue(Student std1)
			{
				std1.Name = "Puneeth";
			}
		}
	}
}

