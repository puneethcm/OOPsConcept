using System;
namespace OOPsConcept
{
	public class Abstraction
	{
		public abstract class Employee
		{
			public abstract int EmployeeSalary();
			public void EmployeeName()
			{
				Console.WriteLine("Puneeth");
			}
		}
		public class EmployeeDetails : Employee
		{
            public override int EmployeeSalary()
            {
				return 500000;
            }
        }
	}
}

