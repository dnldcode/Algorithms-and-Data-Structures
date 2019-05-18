using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
	class InsertionSort
	{
		static public int[] Sort(int[] array)
		{
			for (int i = 1; i < array.Length; i++)
			{
				int j = i;
				while (j > 0 && array[j - 1] > array[j])
				{
					int tmp = array[j - 1];
					array[j - 1] = array[j];
					array[j] = tmp;
					j--;
				}
			}
			return array;
		}
	}
}
