/*
Lesson 9 Maximum slice problem: MaxSliceSum
Find a maximum sum of a compact subsequence of array elements.
https://codility.com/programmers/task/max_slice_sum/
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodilityLessonSolutions
{
	[TestClass]
	public class Lesson9MaxSliceSum
	{
		// Copied from https://www.martinkysel.com/codility-maxslicesum-solution-2/
		public int solution(int[] A)
		{
			int max_ending = -1000000;
			int max_slice = -1000000;
			foreach (int a in A)
			{
				max_ending = Math.Max(a, max_ending + a);
				max_slice = Math.Max(max_slice, max_ending);
			}
			return max_slice;
		}

		[TestMethod]
		public void MaxSliceSum1()
		{
			int[] A = new int[8] { 3, 2, 6, -1, 4, 5, -1, 2 };
			Assert.AreEqual(20, solution(A));
		}

		[TestMethod]
		public void MaxSliceSum2()
		{
			int[] A = new int[5] { 3, 2, -6, 4, 0 };
			Assert.AreEqual(5, solution(A));
		}

	}
}