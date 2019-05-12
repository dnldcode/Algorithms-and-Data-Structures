using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
	static class LinearSearch
	{
		public static bool SimpleLinearSearch(int[] array, int searchedValue)
		{
			bool res = false;

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == searchedValue)
					res = true;
			}
			Console.WriteLine($"SimpleLinearSearch:\tit took {array.Length} operations to search");
			return res;
		}

		public static bool ImprovedLinearSearch(int[] array, int searchedValue)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == searchedValue)
				{
					Console.WriteLine($"ImprovedLinearSearch:\tit took {i + 1} operations to search");
					return true;
				}
			}
			Console.WriteLine($"SimpleLinearSearch:\tit took {array.Length} operations to search");
			return false;
		}

		public static bool ImprovedLinearSearchWithSentinel(int[] array, int searchedValue)
		{
			int last = array[array.Length - 1];

			array[array.Length - 1] = searchedValue;

			int i = 0;
			while (array[i] != searchedValue)
				i++;

			if (i < array.Length - 1 || last == searchedValue)
			{
				Console.WriteLine($"ImprovedLinearSearchWithSentinel:\tit took {i + 1} operations to search");
				return true;
			}
			Console.WriteLine($"SimpleLinearSearch:\tit took {array.Length} operations to search");
			return false;

		}
	}
}
