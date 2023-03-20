using System;
namespace OOPsConcept
{
	public class TypesOfInheritance
	{
        // hierarchical inheritance
        public class ClassA  //base class
        {
            public string msg()
            {
                return "this is A class Method";
            }
        }
        public class ClassB : ClassA
        {
            public string info()
            {
                msg();
                return "this is B class Method";
            }
            public class ClassC : ClassA
            {
                public string getinfo()
                {
                    msg();
                    return "this is C class Method";
                }
            }
        }
    }
    // Melti Level inheritance
    public class Person
    {
        public void person()
        {
             Console.WriteLine("this is the person class");
        }
    }
    public class Bird : Person
    {
        public void bird()
        {
            person();
            Console.WriteLine("this is the bird class");
        }
    }
    public class Animal : Bird
    {
        public void animal()
        {
            person();
            bird();
            Console.WriteLine("this is the animal class");
        }
    }
}

