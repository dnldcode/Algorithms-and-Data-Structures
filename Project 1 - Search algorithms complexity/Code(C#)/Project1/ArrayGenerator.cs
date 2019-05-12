using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
	static class ArrayGenerator
	{
		public static int[] GenerateRandomArray(int size)
		{
			Random R = new Random();
			int[] array = new int[size];

			for (int i = 0; i < size; i++)
				array[i] = R.Next(-50000, 50000);

			return array;
		}

		public static int[] GenerateSortedAscendingArray(int size)
		{
			Random R = new Random();
			int[] array = new int[size];

			for (int i = 0; i < size; i++)
				array[i] = R.Next(-5000, 5000);

			Array.Sort(array);

			return array;
		}
	}
}
