using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
	class SelectionSort
	{
		static public int[] Sort(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				int minIndex = i;
				for (int j = i + 1; j < array.Length; j++)
					minIndex = (array[minIndex] < array[j]) ? minIndex : j;

				int tmp = array[i];
				array[i] = array[minIndex];
				array[minIndex] = tmp;
			}
			return array;
		}
	}
}
