using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					Console.WriteLine("Measure number: {0}, Size: {1}\n", (j + 1), 100000000 * (i + 1));
					int[] array = ArrayGenerator.GenerateRandomArray(100000000 * (i + 1));

					int target = new Random().Next(-50000, 50000);

					var watch = System.Diagnostics.Stopwatch.StartNew();

					LinearSearch.SimpleLinearSearch(array, target);

					watch.Stop();
					Console.WriteLine("\t\t\tand also took {0}ms\n", watch.Elapsed.TotalMilliseconds);

					watch.Restart();

					LinearSearch.ImprovedLinearSearch(array, target);

					watch.Stop();
					Console.WriteLine("\t\t\tand also took {0}ms\n", watch.Elapsed.TotalMilliseconds);

					watch.Restart();

					LinearSearch.ImprovedLinearSearchWithSentinel(array, target);

					watch.Stop();
					Console.WriteLine("\t\t\t\t\tand also took {0}ms\n", watch.Elapsed.TotalMilliseconds);

					watch.Restart();

					BinarySearch.SearchBinary(array, target);

					watch.Stop();
					Console.WriteLine("\t\tand also took {0}ms\n", watch.Elapsed.TotalMilliseconds);

					Console.WriteLine("-----------------------------------------------------");
					array = null;
				}
			}
		}
	}
}