/*
Lesson 2 Arrays: OddOccurrencesInArray
Find value that occurs in odd number of elements.
https://codility.com/programmers/task/odd_occurrences_in_array/
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodilityLessonSolutions
{
	[TestClass]
	public class Lesson2OddOccurencesInArray
	{
		public int solution(int[] A)
		{
			Array.Sort(A);
			for (int i = 0; i < A.Length - 1; i = i + 2)
			{
				if (A[i] != A[i + 1])
					return A[i];
			}
			return A[A.Length - 1];
		}

		[TestMethod]
		public void OccurencesInArrayLargeArray1()
		{
			int count = 999999;
			int[] A = new int[count];
			for (int i = 0; i < count; i++)
			{
				A[i] = 0;
			}
			A[count - 1] = 1;
			Assert.AreEqual(1, solution(A));
		}

		[TestMethod]
		public void OccurencesInArraySmallArray1()
		{
			int[] A = new int[7] { 9, 3, 9, 3, 9, 7, 9 };
			Assert.AreEqual(7, solution(A));
		}

		[TestMethod]
		public void OccurencesInArraySmallArray2()
		{
			int[] A = new int[5] { 1, 2, 2, 2, 2 };
			Assert.AreEqual(1, solution(A));
		}

		[TestMethod]
		public void OccurencesInArraySmallArray3()
		{
			int[] A = new int[7] { 4, 3, 4, 3, 4, 4, 3 };
			Assert.AreEqual(3, solution(A));
		}

	}
}