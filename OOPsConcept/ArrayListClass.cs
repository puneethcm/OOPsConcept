using System;
using System.Collections;
namespace OOPsConcept
{
	public class ArrayListClass
	{
        //ArrayList personList = new ArrayList();
        public void ArrayListDemo()
		{
			ArrayList personList = new ArrayList();
			personList.Add(50);
			personList.Add("puneeth");
			personList.Add("Abhi");

			foreach(var items in personList)
			{
                Console.WriteLine(items);
            }	
        }

        public void UpdateItem()
        {
            ArrayList personList = new ArrayList();
            personList.Add(50);
            personList.Add("puneeth");
            personList.Add("Abhi");

            Console.WriteLine("\nAfter update");
            personList[2] = "kumar";
            foreach (var items in personList)
            {
                Console.WriteLine(items);
            }
        }

        public void InsertItem()
        {
            ArrayList personList = new ArrayList();
            personList.Add(50);
            personList.Add("puneeth");
            personList.Add("Abhi");

            Console.WriteLine("\nInserting");
            personList.Insert(1, "Karthik");
            foreach (var items in personList)
            {
                Console.WriteLine(items);
            }
        }

        public void RemoveItem()
        {
            ArrayList personList = new ArrayList();
            personList.Add(50);
            personList.Add("puneeth");
            personList.Add("Abhi");

            Console.WriteLine("\nAfter Removing");
            personList.Remove("Karthik");
            foreach (var items in personList)
            {
                Console.WriteLine(items);
            }
        }
    }
}

