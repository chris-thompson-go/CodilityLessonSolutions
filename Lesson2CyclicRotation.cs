/*
Lesson 2 Arrays: CyclicRotation
Rotate an array to the right by a given number of steps.
https://codility.com/programmers/task/cyclic_rotation
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodilityLessonSolutions
{
	[TestClass]
	public class Lesson2CyclicRotation
	{
		public int[] solution(int[] A, int K)
		{
			if (A.Length == 0 || K == 0)
				return A;
			int[] N = new int[A.Length];
			int[] N1 = new int[A.Length];
			for (int k = 1; k <= K; k++)
			{
				Array.Copy(A, 0, N, 1, A.Length - 1);
				N[0] = A[A.Length - 1];
				Array.Copy(N, A, N.Length);
			}
			return N;
		}

		[TestMethod]
		public void CyclicRotationArraySingleElementRotate1()
		{
			int[] A = new int[1] { 1 };
			Assert.IsTrue(A.SequenceEqual(solution(A, 1)));
		}

		[TestMethod]
		public void CyclicRotationArraySingleElementRotate3()
		{
			int[] A = new int[1] { 1 };
			Assert.IsTrue(A.SequenceEqual(solution(A, 3)));
		}

		[TestMethod]
		public void CyclicRotationArraySmallArray()
		{
			int[] A = new int[5] { 3, 8, 9, 7, 6 };
			int[] E = new int[5] { 9, 7, 6, 3, 8 };
			Assert.IsTrue(E.SequenceEqual(solution(A, 3)));
		}

	}
}