/*
Lesson 7 Stacks and Queues: Brackets
Determine whether a given string of parentheses is properly nested.
https://codility.com/programmers/task/brackets/
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodilityLessonSolutions
{
	[TestClass]
	public class Lesson7Brackets
	{
		public int solution(string S)
		{
			Stack<char> stack = new Stack<char>();
			char last;
			foreach (char c in S)
			{
				if (c == '[' || c == '{' || c == '(')
				{
					stack.Push(c);
				}
				else
				{
					if (stack.Count == 0)
						return 0;
					last = stack.Pop();
					if (!IsMatch(last, c))
						return 0;
				}
			}
			if (stack.Count != 0)
				return 0;
			return 1;
		}

		public bool IsMatch(char left, char right)
		{
			if (left == '(' && right == ')')
				return true;
			if (left == '[' && right == ']')
				return true;
			if (left == '{' && right == '}')
				return true;
			return false;
		}


		[TestMethod]
		public void BracketsImproperlyNested1()
		{
			string S = "([)()]";
			Assert.AreEqual(0, solution(S));
		}

		[TestMethod]
		public void BracketsProperlyNested1()
		{
			string S = "()";
			Assert.AreEqual(1, solution(S));
		}

		[TestMethod]
		public void BracketsProperlyNested2()
		{
			string S = "[()]";
			Assert.AreEqual(1, solution(S));
		}

		[TestMethod]
		public void BracketsProperlyNested3()
		{
			string S = "{[()()]}";
			Assert.AreEqual(1, solution(S));
		}


	}
}