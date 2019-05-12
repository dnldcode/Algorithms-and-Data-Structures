using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
	class Program
	{
		static void Main(string[] args)
		{
			CoinChange.MakeChangeDynamic(new int[] { 1, 3, 4 }, 6);

			Stopwatch stopwatch = new Stopwatch();

			for (int i = 10; i <= 20; i++)
			{
				int length = (int)Math.Pow(2, i);
				int[] coins = new int[length];

				coins[0] = 1;
				for (int j = 1; j < length; j++)
					coins[j] = (j + 1) * 2;

				stopwatch.Restart();
				Console.WriteLine($"Greedy algorithm for general case(100) coins = {length}:\n");
				CoinChange.MakeChange(coins, 100);
				stopwatch.Stop();
				Console.WriteLine("It took " + stopwatch.Elapsed.TotalMilliseconds);

				stopwatch.Restart();
				Console.WriteLine($"Dynamic solution for general case(100) coins = {length}:\n");
				CoinChange.MakeChangeDynamic(coins, 100);
				stopwatch.Stop();
				Console.WriteLine("Time: " + stopwatch.Elapsed.TotalMilliseconds);
				Console.WriteLine("----------------------------------");
			}

			for (int i = 10; i <= 20; i++)
			{
				int[] coins = new int[7] { 1, 2, 5, 10, 20, 50, 100 };

				int change = (int)Math.Pow(2, i);

				stopwatch.Restart();
				Console.WriteLine($"Greedy algorithm for general case(100) change = {change}:\n");
				CoinChange.MakeChange(coins, change);
				stopwatch.Stop();
				Console.WriteLine("It took " + stopwatch.Elapsed.TotalMilliseconds);

				stopwatch.Restart();
				Console.WriteLine($"\nCoin change for general case(100) change = {change}:\n");
				CoinChange.MakeChangeDynamic(coins, change);
				stopwatch.Stop();
				Console.WriteLine("Time: " + stopwatch.Elapsed.TotalMilliseconds);
				Console.WriteLine("----------------------------------");
			}
		}
	}
}