using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
	class MergeSort
	{
		static public int[] Sort(int[] array)
		{
			if (array.Length <= 1)
				return array;

			List<int> sortedArray = array.ToList();
			List<int> left = new List<int>();
			List<int> right = new List<int>();

			int middle = sortedArray.Count / 2;
			for (int i = 0; i < middle; i++)
				left.Add(sortedArray[i]);
			for (int i = middle; i < sortedArray.Count; i++)
				right.Add(sortedArray[i]);

			left = MergeSort.Sort(left.ToArray()).ToList();
			right = MergeSort.Sort(right.ToArray()).ToList();
			return Merge(left, right).ToArray();
		}

		static public List<int> Merge(List<int> left, List<int> right)
		{
			List<int> result = new List<int>();

			while (left.Count > 0 || right.Count > 0)
			{
				if (left.Count > 0 && right.Count > 0)
				{
					if (left.First() <= right.First())
					{
						result.Add(left.First());
						left.Remove(left.First());
					}
					else
					{
						result.Add(right.First());
						right.Remove(right.First());
					}
				}
				else if (left.Count > 0)
				{
					result.Add(left.First());
					left.Remove(left.First());
				}
				else if (right.Count > 0)
				{
					result.Add(right.First());
					right.Remove(right.First());
				}
			}
			return result;
		}
	}
}
