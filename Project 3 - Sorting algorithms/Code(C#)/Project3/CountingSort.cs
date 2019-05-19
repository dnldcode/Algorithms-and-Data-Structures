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

			int min = array.Min();
			int max = array.Max();

			int[] counts = new int[max - min + 1];

			for (int i = 0; i < array.Length; i++)
				counts[array[i] - min]++;

			counts[0]--;
			for (int i = 1; i < counts.Length; i++)
				counts[i] += counts[i - 1];

			for (int i = array.Length - 1; i >= 0; i--)
				sortedArray[counts[array[i] - min]--] = array[i];

			return sortedArray;
		}
	}
}
