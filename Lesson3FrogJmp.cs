/*
Lesson 3 Time Complexity: FrogJmp
Count minimal number of jumps from position X to Y
https://codility.com/programmers/task/frog_jmp/
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodilityLessonSolutions
{
	[TestClass]
	public class Lesson3FrogJmp
	{
		public int solution(int X, int Y, int D)
		{
			decimal d = ((decimal)Y - (decimal)X) / (decimal)D;
			return (int)Math.Ceiling(d);
		}

		[TestMethod]
		public void FrogJmpLargeInteger1()
		{
			int i = 1000000000;
			Assert.AreEqual(0, solution(i, i, i));
		}

		[TestMethod]
		public void FrogJmpLargeInteger2()
		{
			int i = 1000000000;
			Assert.AreEqual(1, solution(i - 1, i, i));
		}

		[TestMethod]
		public void FrogJmpLargeInteger3()
		{
			int i = 1000000000;
			Assert.AreEqual(i - 1, solution(1, i, 1));
		}

		[TestMethod]
		public void FrogJmpLargeInteger4()
		{
			int i = 1000000000;
			Assert.AreEqual(499999998, solution(5, i, 2));
		}

		[TestMethod]
		public void FrogJmpSmallInteger1()
		{
			Assert.AreEqual(1, solution(1, 2, 1));
		}

		[TestMethod]
		public void FrogJmpSmallInteger2()
		{
			Assert.AreEqual(4, solution(1, 5, 1));
		}

		[TestMethod]
		public void FrogJmpSmallInteger3()
		{
			Assert.AreEqual(3, solution(10, 85, 30));
		}

	}
}