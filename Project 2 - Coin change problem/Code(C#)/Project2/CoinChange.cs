using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
	static class CoinChange
	{
		public static string MakeChange(int change)
		{
			if (change < 0)
				throw new Exception("Input should be a positive integer");

			int[] coins = new int[7] { 1, 2, 5, 10, 20, 50, 100 };

			Array.Sort(coins);
			Array.Reverse(coins);

			string res = "";
			foreach (int coin in coins)
			{
				int howMany = change / coin;
				change = change % coin;
				if (howMany != 0)
					res += String.Format($"{howMany}x{coin}\n");
			}
			return res;
		}

		public static void MakeChange(int[] arrCoins, int change)
		{
			if (change < 0)
				throw new Exception("Input should be a positive integer");

			foreach (int coin in arrCoins)
			{
				if (coin < 0)
					throw new Exception("Coin should be positive integer");
			}

			if (arrCoins.Length != arrCoins.Distinct().Count())
				throw new Exception("Coins should have unique values");

			if (!arrCoins.Contains(1))
				throw new Exception("One coin must have value of 1");

			int[] coins = new int[arrCoins.Length];
			Array.Copy(arrCoins, coins, arrCoins.Length);
			Array.Sort(coins);
			Array.Reverse(coins);

			List<string> changeList = new List<string>();
			foreach (int coin in coins)
			{
				int howMany = change / coin;
				change = change % coin;
				if (howMany != 0)
					changeList.Add(String.Format($"{howMany}x{coin}"));
			}

			Console.WriteLine(string.Join(", ", changeList));
		}

		public static void MakeChangeDynamic(int[] arrCoins, int change)
		{
			if (change < 0)
				throw new Exception("Input should be a positive integer");

			foreach (int coin in arrCoins)
			{
				if (coin < 0)
					throw new Exception("Coin should be positive integer");
			}

			if (arrCoins.Length != arrCoins.Distinct().Count())
				throw new Exception("Coins should have unique values");

			if (!arrCoins.Contains(1))
				throw new Exception("One coin must have value of 1");

			int[] coins = new int[arrCoins.Length];
			Array.Copy(arrCoins, coins, arrCoins.Length);
			Array.Sort(coins);

			int[] minCoins = new int[change + 1];
			int[] firstCoinIndex = new int[change + 1];

			for (int currChange = 0; currChange < change + 1; currChange++)
			{
				int coinCount = currChange;
				int newCoinIndex = 0;

				for (int coinIndex = 0; coinIndex < coins.Length; coinIndex++)
				{
					int coin = coins[coinIndex];
					if (coin > currChange)
						continue;
					if (1 + minCoins[currChange - coin] < coinCount)
					{
						coinCount = 1 + minCoins[currChange - coin];
						newCoinIndex = coinIndex;
					}
				}
				minCoins[currChange] = coinCount;
				firstCoinIndex[currChange] = newCoinIndex;
			                              }

			int currChange2 = change;
			int[] coincount = new int[arrCoins.Length];
			List<string> changeList = new List<string>();

			while (currChange2 > 0)
			{
				int coin = coins[firstCoinIndex[currChange2]];
				coincount[firstCoinIndex[currChange2]]++;
				currChange2 -= coin;
			}
			for (int i = 0; i < coincount.Length; i++)
			{
				if (coincount[i] > 0)
					changeList.Add(coincount[i] + "x" + coins[i]);
			}
			changeList.Reverse();
			Console.WriteLine(string.Join(", ", changeList));

		}
	}
}
