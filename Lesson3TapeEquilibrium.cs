/*
Lesson 3 Time Complexity: TapeEquilibrium
Minimize the value |(A[0] + ... + A[P-1]) - (A[P] + ... + A[N-1])|.
https://codility.com/programmers/task/tape_equilibrium/
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodilityLessonSolutions
{
	[TestClass]
	public class Lesson3TapeEquilibrium
	{
		public int solution(int[] A)
		{
			int minDiff = int.MaxValue;
			int left = 0;
			int right = 0;
			//if (A.Length == 1)
			//	return Math.Abs(-A[0]);
			for (int i = 0; i < A.Length; i++)
			{
				right += A[i];
			}
			for (int i = 1; i < A.Length; i++)
			{
				left += A[i - 1];
				right -= A[i - 1];
				minDiff = Math.Min(minDiff, Math.Abs(left - right));
			}
			return minDiff;
		}

		[TestMethod]
		public void TapeEquilibriumIdenticalElements()
		{
			int[] A = new int[5] { 1, 1, 1, 1, 1 };
			Assert.AreEqual(1, solution(A));
		}

		[TestMethod]
		public void TapeEquilibriumLargeArrayIdenticalElements()
		{
			int[] A = new int[100000];
			for (int i = 1; i < 100000; i++)
			{
				A[i] = 1000;
			}
			Assert.AreEqual(1000, solution(A));
		}

		[TestMethod]
		public void TapeEquilibriumSmallArray()
		{
			int[] A = new int[5] { 3, 1, 2, 4, 3 };
			Assert.AreEqual(1, solution(A));
		}

		[TestMethod]
		public void TapeEquilibriumSmallArrayNegativeValues()
		{
			int[] A = new int[2] { -1000, 1000 };
			Assert.AreEqual(2000, solution(A));
		}

		[TestMethod]
		public void TapeEquilibriumZero()
		{
			int[] A = new int[2] { -3, -3 };
			Assert.AreEqual(0, solution(A));
		}
	}
}