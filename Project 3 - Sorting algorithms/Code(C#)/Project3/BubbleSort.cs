using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
	class BubbleSort
	{
		static public int[] Sort(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length - 1 - i; j++)
				{
					if (array[j] > array[j + 1])
					{
						int tmp = array[j + 1];
						array[j + 1] = array[j];
						array[j] = tmp;
					}
				}
			}
			return array;
		}
	}
}
