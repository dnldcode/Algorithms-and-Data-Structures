using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
	public enum SortType { Insertion, Selection, Bubble, Cocktail, Counting, Merge };

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
				case SortType.Cocktail:
					return CocktailSort.Sort(array);
				case SortType.Counting:
					return CountingSort.Sort(array);
				case SortType.Merge:
					return MergeSort.Sort(array);
			}
			return null;
		}
	}
}
