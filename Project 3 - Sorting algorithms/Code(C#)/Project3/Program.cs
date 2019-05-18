using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(string.Join(", ", MergeSort.Sort(ArrayGenerator.Generate(20, 0, 100, ArraySort.None))));
		}
	}
}
