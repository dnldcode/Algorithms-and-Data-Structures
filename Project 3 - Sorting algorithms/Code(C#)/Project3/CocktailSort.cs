using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
	class CocktailSort
	{
		static public int[] Sort(int[] array)
		{
			bool swapped = true;
			int start = 0;
			int end = array.Length;

			while (swapped)
			{
				swapped = false;
				for (int i = start; i < end - 1; i++)
				{
					if (array[i] > array[i + 1])
					{
						int tmp = array[i + 1];
						array[i + 1] = array[i];
						array[i] = tmp;
						swapped = true;
					}
				}

				if (!swapped)
					break;
				end--;

				for (int i = end - 1; i >= start; i--)
				{
					if (array[i] > array[i + 1])
					{
						int tmp = array[i + 1];
						array[i + 1] = array[i];
						array[i] = tmp;
						swapped = true;
					}
				}
				start++;
			}

			return array;
		}
	}
}
