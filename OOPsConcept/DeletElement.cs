using System;
namespace OOPsConcept
{
	public class DeletElement
	{
		public static void DeleteElement(int[] arr, int delete)
		{
			int k = 0;
			int[] result = new int[arr.Length - 1];

			for(int i=0; i < arr.Length; i++)
			{
				if (delete != arr[i])
				{
					result[k] = arr[i];
					k++;
				}
			}
			foreach(int j in result)
			{
				Console.Write(j + " ");
			}
		}
	}
}

