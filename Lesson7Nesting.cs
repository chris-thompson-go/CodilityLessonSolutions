/*
Lesson 7 Stacks and Queues: Nesting
Determine whether a given string of parentheses is properly nested.
https://codility.com/programmers/task/nesting/
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodilityLessonSolutions
{
	[TestClass]
	public class Lesson7Nesting
	{
		public int solution(string S)
		{
			Stack<char> stack = new Stack<char>();
			foreach (char c in S)
			{
				if (c == '(')
				{
					stack.Push(c);
				}
				else
				{
					if (stack.Count == 0)
						return 0;
					stack.Pop();
				}
			}
			if (stack.Count != 0)
				return 0;
			return 1;
		}

		[TestMethod]
		public void NestingImproper1()
		{
			string S = "())";
			Assert.AreEqual(0, solution(S));
		}

		[TestMethod]
		public void NestingImproper2()
		{
			string S = "()(()()(((()())(()()))";
			Assert.AreEqual(0, solution(S));
		}

		[TestMethod]
		public void NestingProper1()
		{
			string S = "()";
			Assert.AreEqual(1, solution(S));
		}

		[TestMethod]
		public void NestingProper2()
		{
			string S = "(()(())())";
			Assert.AreEqual(1, solution(S));
		}

		[TestMethod]
		public void NestingProper3()
		{
			string S = "()()";
			Assert.AreEqual(1, solution(S));
		}

	}
}