using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
	public enum SortType { Insertion, Selection, Bubble, Coctail };

	static class Sort
	{
		public static int[] SortArray(int[] array, SortType sortType)
		{
			switch (sortType)
			{
				case SortType.Insertion:
					return InsertionSort.Sort(array);
				case SortType.Selection:
					return SelectionSort.Sort(array);
				case SortType.Bubble:
					return BubbleSort.Sort(array);
				case SortType.Coctail:
					return CoctailSort.Sort(array);
			}

			return null;
		}
	}
}
