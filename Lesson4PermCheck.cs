/*
Lesson 4 Counting Elements: PermCheck
Check whether array A is a permutation.
https://codility.com/programmers/task/perm_check/
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodilityLessonSolutions
{
	[TestClass]
	public class Lesson4PermCheck
	{
		public int solution(int[] A)
		{
			int[] distinct = A.Distinct().ToArray();
			Array.Sort(distinct);
			if (A.Length <= 0)
				return 0;
			if (A.Length == 1 && A[0] == 1)
				return 1;
			if (distinct.Length != A.Length)
				return 0;
			if (distinct[distinct.Length - 1] == distinct.Length)
				return 1;
			else
				return 0;
		}

		[TestMethod]
		public void PermCheckLargeArray1()
		{
			int[] A = new int[100000];
			for (int i = 0; i < 100000; i++)
			{
				A[i] = i + 1;
			}
			Assert.AreEqual(1, solution(A));
		}

		[TestMethod]
		public void PermCheckLargeArray2()
		{
			int[] A = new int[100000];
			for (int i = 0; i < 100000; i++)
			{
				A[i] = i + 1;
			}
			A[99999] = 1;
			Assert.AreEqual(0, solution(A));
		}

		[TestMethod]
		public void PermCheckSingleElement()
		{
			int[] A = new int[1] { 1 };
			Assert.AreEqual(1, solution(A));
		}

		[TestMethod]
		public void PermCheckSmallArray()
		{
			int[] A = new int[6] { 1, 2, 3, 4, 5, 1 };
			Assert.AreEqual(0, solution(A));
		}

		[TestMethod]
		public void PermCheckTwoElements()
		{
			int[] A = new int[2] { 1, 1 };
			Assert.AreEqual(0, solution(A));
		}

	}
}