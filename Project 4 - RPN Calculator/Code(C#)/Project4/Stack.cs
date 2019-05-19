using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
	class Stack<T>
	{
		List<T> stack = new List<T>(10);

		public void Push(T item)
		{
			if (stack.Count == 10)
				throw new Exception("Stack Overflow Exception");

			stack.Add(item);
		}

		public bool IsEmpty()
		{
			return stack.Count == 0;
		}

		public int Count()
		{
			return this.stack.Count;
		}

		public T Peek()
		{
			if (this.IsEmpty())
				throw new Exception("Stack is empty");

			return stack[stack.Count - 1];
		}

		public T Pop()
		{
			if (this.IsEmpty())
				throw new Exception("Stack is empty");

			var item = stack[stack.Count - 1];
			stack.Remove(item);
			return item;
		}
	}
}
