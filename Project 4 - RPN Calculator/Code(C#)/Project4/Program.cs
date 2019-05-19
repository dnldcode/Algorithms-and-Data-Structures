using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(RPNCalculator.InfixToPostfix("2 * ( 3 + 8 ) / 4 "));
			Console.WriteLine(RPNCalculator.Calculate(RPNCalculator.InfixToPostfix(RPNCalculator.InfixToPostfix("2 * ( 3 + 8 ) / 4 "))));
		}
	}
}
