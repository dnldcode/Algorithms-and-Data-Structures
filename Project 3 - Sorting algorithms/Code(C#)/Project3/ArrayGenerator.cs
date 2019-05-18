using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
	public enum ArraySort { Ascending, Descending, VShape, AShape, None };

	static class ArrayGenerator
	{
		public static int[] Generate(int size, int n)
		{
			if (size < 1)
				throw new Exception("Incorrect array size");

			Random R = new Random();
			int[] array = new int[size];

			for (int i = 0; i < size; i++)
				array[i] = n;

			return array;
		}

		public static int[] Generate(int size, int rangeMin, int rangeMax, ArraySort sortType)
		{
			if (size < 1)
				throw new Exception("Incorrect array size");

			if (rangeMin >= rangeMax)
				throw new Exception("Incorrect array range");

			Random R = new Random();
			int[] array = new int[size];

			for (int i = 0; i < size; i++)
				array[i] = R.Next(rangeMin, rangeMax);

			if (sortType == ArraySort.None)
				return array;

			Array.Sort(array);
			switch (sortType)
			{
				case ArraySort.Descending:
					Array.Reverse(array);
					break;
				case ArraySort.AShape:
				case ArraySort.VShape:
					if (sortType == ArraySort.AShape)
						Array.Reverse(array);

					int[] shapeArray = new int[array.Length];
					int j = (int) Math.Floor((double)(array.Length - 1)/ 2);

					for (int i = 0; i < array.Length; i++)
					{
						shapeArray[j] = array[i];
						j = (i % 2 == 0) ? j + (i + 1) : j - (i + 1);
					}
					array = shapeArray;
					break;
			}

			return array;
		}
	}
}
