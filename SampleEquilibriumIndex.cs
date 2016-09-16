/*
Sample: Equilbrium Index
https://codility.com/demo/take-sample-test/

*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityLessonSolutions
{
	[TestClass]
	public class SampleEquilibriumIndex
	{
		public int solution(int[] A)
		{
			//if (A.Length == 0)
			//	return -1;
			//if (A.Length == 1)
			//	return 0;
			long leftSum = 0;
			long rightSum = 0;
			for (int i = 0; i < A.Length; i++)
				rightSum += A[i];
			for (int i = 0; i < A.Length; i++)
			{
				rightSum = rightSum - A[i];
				if (leftSum == rightSum)
					return i;
				leftSum += A[i];
			}
			return -1;
		}

		[TestMethod]
		public void EquilibriumIndexEmptyArray()
		{
			int[] A = new int[0];
			Assert.AreEqual(-1, solution(A));
		}

		[TestMethod]
		public void EquilibriumIndexIdenticalElements()
		{
			int[] A = new int[5] { -1, -1, -1, -1, -1 };
			Assert.AreEqual(2, solution(A));
		}

		[TestMethod]
		public void EquilibriumIndexLargeArray()
		{
			int[] A = new int[100000];
			for (int i = 0; i < 100000; i++)
			{
				A[i] = -1;
			}
			A[99999] = -99998;
			Assert.AreEqual(99998, solution(A));
		}

		[TestMethod]
		public void EquilibriumIndexLargeNegativeValues()
		{
			int[] A = new int[3] { -2147483648, -2147483648, -2147483648 };
			Assert.AreEqual(1, solution(A));
		}

		[TestMethod]
		public void EquilibriumIndexLargeValues1()
		{
			int[] A = new int[3] { 0, -2147483648, -2147483648 };
			Assert.AreEqual(-1, solution(A));
		}

		[TestMethod]
		public void EquilibriumIndexLargeValues2()
		{
			int[] A = new int[9] { -2147483648, 2147483647, 2147483647, -2147483648, 1, 2147483647, 2147483647, -2147483648, -2147483648 };
			Assert.AreEqual(4, solution(A));
		}

		[TestMethod]
		public void EquilibriumIndexSingleElement1()
		{
			int[] A = new int[1] { 0 };
			Assert.AreEqual(0, solution(A));
		}

		[TestMethod]
		public void EquilibriumIndexSingleElement2()
		{
			int[] A = new int[1] { 8 };
			Assert.AreEqual(0, solution(A));
		}

		[TestMethod]
		public void EquilibriumIndexSmallArray1()
		{
			int[] A = new int[8] { -1, 3, -4, 5, 1, -6, 2, 1 };
			Assert.AreEqual(1, solution(A));
		}

		[TestMethod]
		public void EquilibriumIndexSmallArray2()
		{
			int[] A = new int[5] { 0, 1, 2, -3, 4 };
			Assert.AreEqual(2, solution(A));
		}

		[TestMethod]
		public void EquilibriumIndexTwoElement1()
		{
			int[] A = new int[2] { 0, 1 };
			Assert.AreEqual(1, solution(A));
		}

		[TestMethod]
		public void EquilibriumIndexTwoElement2()
		{
			int[] A = new int[2] { -100, 100 };
			Assert.AreEqual(-1, solution(A));
		}

	}
}