using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
	public class RPNCalculator
	{
		public static string InfixToPostfix(string infix)
		{
			Stack<string> operatorStack = new Stack<string>();
			List<string> postfix = new List<string>();

			foreach (var item in infix.Split(' '))
			{
				if (item == "(")
					operatorStack.Push(item);
				else if (item == ")")
				{
					while (operatorStack.Peek() != "(")
						postfix.Add(operatorStack.Pop());
					operatorStack.Pop();
				}
				else if (double.TryParse(item, out double op))
					postfix.Add(item);
				else
				{
					if (!operatorStack.IsEmpty() && Precedence(operatorStack.Peek()) >= Precedence(item) && Associativity(item) == "left")
						postfix.Add(operatorStack.Pop());
					operatorStack.Push(item);
				}
			}
			while (!operatorStack.IsEmpty())
				postfix.Add(operatorStack.Pop());

			return string.Join(" ", postfix);
		}

		public static double Calculate(string expression)
		{
			if (expression.Trim() == "")
				throw new Exception("No input given");

			Stack<double> operandStack = new Stack<double>();
			foreach (var item in expression.Split(' '))
			{
				if (double.TryParse(item, out double operand))
				{
					operandStack.Push(operand);

					var numberOfOperators = expression.Split(' ').Where(str => str.Trim() != "")
																 .Select(str => str).Count()- operandStack.Count();
					if (operandStack.Count() > numberOfOperators + 1)
						throw new Exception("Wrong equation: not enough operators");
				}
				else if (item != "")
				{
					if (operandStack.Count() < 2)  
						throw new Exception("Wrong equation: too many operators");
					double n1 = operandStack.Pop();
					double n2 = operandStack.Pop();
					operandStack.Push(Calculate(n2, n1, item));
				}
			}
			return operandStack.Pop();
		}

		private static double Calculate(double n1, double n2, string action)
		{
			switch (action)
			{
				case "+":
					return n1 + n2;
				case "-":
					return n1 - n2;
				case "*":
					return n1 * n2;
				case "/":
					return (n2 != 0) ? n1 / n2 : Double.PositiveInfinity;
				case "^":
					return Math.Pow(n1, n2);
				default:
					throw new Exception("Incorrect operand found");
			}
		}

		private static int Precedence(string token)
		{
			switch (token)
			{
				case "+":
					return 2;
				case "-":
					return 2;
				case "*":
					return 3;
				case "/":
					return 3;
				case "^":
					return 4;
				default:
					return 0;
			}
		}

		private static string Associativity(string token)
		{
			switch (token)
			{
				case "+":
					return "left";
				case "-":
					return "left";
				case "*":
					return "left";
				case "/":
					return "left";
				case "^":
					return "right";
				default:
					return "left";
			}
		}
	}
}
