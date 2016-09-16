/*
Lesson 5 Prefix Sums: PassingCars
Count the number of passing cars on the road.
https://codility.com/programmers/task/passing_cars/
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityLessonSolutions
{
	[TestClass]
	public class Lesson5PassingCars
	{
		public int solution(int[] A)
		{
			int passingCars = 0;
			int west = 0;
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] == 1)
					west++;
			}
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] == 0)
					passingCars += west;
				else
					west--;
				if (passingCars > 1000000000)
					return -1;
			}
			return passingCars;
		}

		[TestMethod]
		public void PassingCarsLargeArray1()
		{
			int[] A = new int[100000];
			for (int i = 0; i < 100000; i++)
				A[i] = 0;
			A[99998] = 1;
			A[99999] = 1;
			Assert.AreEqual(99998 * 2, solution(A));
		}

		[TestMethod]
		public void PassingCarsLargeArray2()
		{
			int[] A = new int[100000];
			for (int i = 0; i < 100000; i++)
				A[i] = 0;
			A[99997] = 1;
			A[99998] = 1;
			A[99999] = 1;
			Assert.AreEqual(99997 * 3, solution(A));
		}

		[TestMethod]
		public void PassingCarsLargeArray3()
		{
			int[] A = new int[100000];
			for (int i = 0; i < 100000; i++)
				A[i] = 0;
			A[99999] = 1;
			Assert.AreEqual(99999, solution(A));
		}

		[TestMethod]
		public void PassingCarsLargeArray4()
		{
			int[] A = new int[100000];
			for (int i = 0; i < 100000; i++)
				A[i] = 1;
			A[99999] = 0;
			Assert.AreEqual(0, solution(A));
		}

		[TestMethod]
		public void PassingCarsLargeArray5()
		{
			int[] A = new int[100000];
			for (int i = 0; i < 100000; i++)
				A[i] = 1;
			A[99998] = 0;
			A[99999] = 1;
			Assert.AreEqual(1, solution(A));
		}

		[TestMethod]
		public void PassingCarsLargeArray6()
		{
			int[] A = new int[100000];
			for (int i = 0; i < 100000; i++)
				A[i] = 1;
			A[99997] = 0;
			A[99998] = 0;
			A[99999] = 1;
			Assert.AreEqual(2, solution(A));
		}

		[TestMethod]
		public void PassingCarsSmallArray()
		{
			int[] A = new int[5] { 0, 1, 0, 1, 1 };
			Assert.AreEqual(5, solution(A));
		}

	}
}