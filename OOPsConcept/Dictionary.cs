using System;
using System.Collections.Generic;

namespace OOPsConcept
{
	public class Dictionary
	{
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        public void DictionaryDemo()
		{
			//Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Puneeth");
            dictionary.Add(2, "Prashanth");
            dictionary.Add(3, "Karthick");
            dictionary.Add(4, "Abhiskek");
            Display();

			Console.WriteLine("\nafter update");
			dictionary[5] = "Nithin";
			Display();

			Console.WriteLine("\nafter removed");
			if (dictionary.Remove(2))
			{
				Console.WriteLine("Removed successful");
				Display();
            }
			else
			{
                Console.WriteLine("Removed Failed");
            }

            Console.WriteLine("\nRead");
            if (dictionary.ContainsKey(1))
            {
                string value = dictionary[1];
                Console.WriteLine("Value:" + value);
            }

        }
        public void Display()
		{
            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            
            foreach (KeyValuePair<int, string> element in dictionary)
            {
                Console.WriteLine("Kay: {0}, Value: {1}", element.Key, element.Value);
            }
        }
	}
}

