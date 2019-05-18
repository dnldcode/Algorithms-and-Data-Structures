using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
	class CountingSort
	{
		static public int[] Sort(int[] array)
		{

			int[] sortedArray = new int[array.Length];

			int min = array[0];
			int max = array[0];

			// init array of frequencies
			int[] counts = new int[max - min + 1];

			// init the frequencies
			for (int i = 0; i < array.Length; i++)
			{
				counts[array[i] - min]++;
			}

			// recalculate
			counts[0]--;
			for (int i = 1; i < counts.Length; i++)
			{
				counts[i] = counts[i] + counts[i - 1];
			}

			// Sort the array
			for (int i = array.Length - 1; i >= 0; i--)
			{
				sortedArray[counts[array[i] - min]--] = array[i];
			}

			Console.WriteLine("\n" + "Sorted array :");
			foreach (int aa in sortedArray)
				Console.Write(aa + " ");
			Console.Write("\n");


			return array;
		}
	}
}
