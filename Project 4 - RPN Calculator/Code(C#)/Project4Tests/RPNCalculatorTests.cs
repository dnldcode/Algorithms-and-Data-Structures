using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Tests
{
	[TestClass()]
	public class RPNCalculatorTests
	{
		[TestMethod()]
		public void InfixToPostfixTest()
		{
			Assert.AreEqual(RPNCalculator.InfixToPostfix("2 + 3"), "2 3 +");
			Assert.AreEqual(RPNCalculator.InfixToPostfix("6 - 2"), "6 2 -");
			Assert.AreEqual(RPNCalculator.InfixToPostfix("12 * 5"), "12 5 *");
			Assert.AreEqual(RPNCalculator.InfixToPostfix("3 ^ 2"), "3 2 ^");

			Assert.AreEqual(RPNCalculator.InfixToPostfix("2 + 3 - 2"), "2 3 + 2 -");
			Assert.AreEqual(RPNCalculator.InfixToPostfix("5 * 4 / 9"), "5 4 * 9 /");

			Assert.AreEqual(RPNCalculator.InfixToPostfix("2 + 3 * 5"), "2 3 5 * +");
			Assert.AreEqual(RPNCalculator.InfixToPostfix("5 * 3 + 1"), "5 3 * 1 +");
			Assert.AreEqual(RPNCalculator.InfixToPostfix("2 * 3 + 8 / 4"), "2 3 * 8 4 / +");

			Assert.AreEqual(RPNCalculator.InfixToPostfix("7 * ( 2 + 3 )"), "7 2 3 + *");
			Assert.AreEqual(RPNCalculator.InfixToPostfix("2 * ( 3 + 8 ) / 4"), "2 3 8 + * 4 /");
			Assert.AreEqual(RPNCalculator.InfixToPostfix("9 / ( ( 4 + 2 ) * 3 )"), "9 4 2 + 3 * /");

			Assert.AreEqual(RPNCalculator.InfixToPostfix("2 ^ 3 ^ 4"), "2 3 4 ^ ^");
			Assert.AreEqual(RPNCalculator.InfixToPostfix("4 * 9 ^ 6"), "4 9 6 ^ *");
		}

		[TestMethod()]
		public void CalculateTest()
		{
			Assert.AreEqual(RPNCalculator.Calculate("2 3 +"), 5);
			Assert.AreEqual(RPNCalculator.Calculate("5 4 *"), 20);
			Assert.AreEqual(RPNCalculator.Calculate("4 2 /"), 2);
			Assert.AreEqual(RPNCalculator.Calculate("11 3 -"), 8);
			Assert.AreEqual(RPNCalculator.Calculate("6 2 ^"), 36);

			Assert.AreEqual(RPNCalculator.Calculate("3 1 7 + *"), 24);
			Assert.AreEqual(RPNCalculator.Calculate("5 3 8 12 + * -"), -55);
			Assert.AreEqual(RPNCalculator.Calculate("4 2 + 9 *"), 54);
			Assert.AreEqual(RPNCalculator.Calculate("3 1 - 7 *"), 14);
		}

		[TestMethod()]
		[ExpectedException(typeof(Exception), "No input given")]
		public void NoInputGivenException()
		{
			RPNCalculator.Calculate("");
		}

		[TestMethod()]
		[ExpectedException(typeof(Exception), "Wrong equation: not enough operators")]
		public void NotEnoughOperators()
		{
			RPNCalculator.Calculate("3 3");
		}

		[TestMethod()]
		[ExpectedException(typeof(Exception), "Wrong equation: too many operators")]
		public void TooManyOperators()
		{
			RPNCalculator.Calculate("3 3 + +");
		}

		[TestMethod()]
		[ExpectedException(typeof(Exception), "Stack Overflow Exception")]
		public void StackOverflowException()
		{
			RPNCalculator.Calculate("”1 2 3 4 5 6 7 8 9 10 11 + * + * + * + * + * + *");
		}
	}
}