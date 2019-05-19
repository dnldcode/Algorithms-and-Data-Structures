using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
	class Program
	{
		static void Main(string[] args)
		{
			Stopwatch stopwatch = new Stopwatch();

			for (int i = 0; i < Enum.GetNames(typeof(SortType)).Length; i++)
			{
				Console.WriteLine($"\n{(SortType)i}:");
				for (int j = 0; j < Enum.GetNames(typeof(ArraySort)).Length; j++)
				{
					Console.WriteLine("\t" + (ArraySort)j);

					for (int z = 0; z < 10; z++)
					{
						int size = ((SortType)i != SortType.Counting) ? (int)Math.Pow(2, z + 6) : (int)Math.Pow(2, 15);

						int[] array = ((SortType)i != SortType.Counting) ? ArrayGenerator.Generate(size, -100, 100, (ArraySort)j) : ArrayGenerator.Generate(size, 0, (int)Math.Pow(2, z + 10), (ArraySort)j);
						stopwatch.Start();
						Sort.SortArray(array, (SortType)i);
						stopwatch.Stop();
						Console.WriteLine($"\t\t{(((SortType)i != SortType.Counting) ? "Size" : "A/D")} - {(((SortType)i != SortType.Counting) ? size : ((double)size / (int)Math.Pow(2, z + 10)))}: it took {stopwatch.Elapsed.TotalMilliseconds} ms");
						stopwatch.Reset();
					}
				}
			}
		}
	}
}
