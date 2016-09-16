/*
Lesson 6 Sorting: Triangle
Determine whether a triangle can be built from a given set of edges.
https://codility.com/programmers/task/triangle/
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodilityLessonSolutions
{
	[TestClass]
	public class Lesson6Triangle
	{
		public int solution(int[] A)
		{
			if (A.Length < 3)
				return 0;
			Array.Sort<int>(A);
			for (int p = 0; p < A.Length - 2; p++)
			{
				if ((long)A[p] + (long)A[p + 1] > (long)A[p + 2])
					return 1;
			}
			return 0;
		}

		[TestMethod]
		public void TriangleEmptyArray()
		{
			int[] A = new int[0];
			Assert.AreEqual(0, solution(A));
		}

		[TestMethod]
		public void TriangleLargeArray1()
		{
			int[] A = new int[100000];
			for (int i = 0; i < 100000; i++)
				A[i] = 1;
			Assert.AreEqual(1, solution(A));
		}

		[TestMethod]
		public void TriangleLargeArray2()
		{
			int[] A = new int[100000];
			for (int i = 0; i < 100000; i++)
				A[i] = 0;
			Assert.AreEqual(0, solution(A));
		}

		[TestMethod]
		public void TriangleMaxValue()
		{
			int[] A = new int[3];
			A[0] = int.MaxValue;
			A[1] = int.MaxValue;
			A[2] = int.MaxValue;
			Assert.AreEqual(1, solution(A));
		}

		[TestMethod]
		public void TriangleSingleElement()
		{
			int[] A = new int[1] { 0 };
			Assert.AreEqual(0, solution(A));
		}

		[TestMethod]
		public void TriangleSmallArray1()
		{
			int[] A = new int[6] { 10, 2, 5, 1, 8, 20 };
			Assert.AreEqual(1, solution(A));
		}

		[TestMethod]
		public void TriangleSmallArray2()
		{
			int[] A = new int[4] { 10, 50, 5, 1 };
			Assert.AreEqual(0, solution(A));
		}

		[TestMethod]
		public void TriangleSmallArray3()
		{
			int[] A = new int[6] { -100, 200, -300, 400, -500, 600 };
			Assert.AreEqual(0, solution(A));
		}

		[TestMethod]
		public void TriangleSmallArray4()
		{
			int[] A = new int[3] { 0, 5, -4 };
			Assert.AreEqual(0, solution(A));
		}

		[TestMethod]
		public void TriangleThreeElement()
		{
			int[] A = new int[3] { -1, -1, -1 };
			Assert.AreEqual(0, solution(A));
		}

		[TestMethod]
		public void TriangleTwoElement()
		{
			int[] A = new int[2] { 1, 1 };
			Assert.AreEqual(0, solution(A));
		}
	}
}