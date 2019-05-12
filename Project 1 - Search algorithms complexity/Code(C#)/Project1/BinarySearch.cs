using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
	static class BinarySearch
	{
		public static bool SearchBinary(int[] array, int searchValue)
		{
			int p = 0, r = array.Length - 1;

			int i = 1;
			while (p <= r)
			{
				int q = (int)Math.Floor((double)(p + r) / 2);
				if (array[q] == searchValue)
				{
					Console.WriteLine($"SearchBinary:\tit took {i} operations to search");
					return true;
				}
				else if (array[q] != searchValue && array[q] > searchValue)
					r = q - 1;
				else if (array[q] < searchValue)
					p = q + 1;

				i++;
			}
			Console.WriteLine($"SearchBinary:\tit took {i} operations to search");
			return false;
		}
	}
}
