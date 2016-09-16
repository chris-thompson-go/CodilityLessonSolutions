/*
Lesson 1 Iterations: BinaryGap
Find longest sequence of zeros in binary representation of an integer.
https://codility.com/programmers/task/binary_gap/
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodilityLessonSolutions
{
	[TestClass]
	public class Lesson1BinaryGap
	{
		public int solution(int N)
		{
			int maxgap = 0;
			int gap = 0;
			string s = Convert.ToString(N, 2);
			int firstOne;
			for (firstOne = 0; firstOne < s.Length; firstOne++)
			{
				if (s[firstOne] == '1')
					break;
			}
			for (int i = firstOne; i < s.Length; i++)
			{
				if (s[i] == '1')
				{
					if (gap > 0)
					{
						maxgap = Math.Max(maxgap, gap);
						gap = 0;
					}
				}
				else
				{
					gap++;
				}
			}
			return maxgap;
		}

		[TestMethod]
		public void BinaryGap1041()
		{
			Assert.AreEqual(5, solution(1041));
		}

		[TestMethod]
		public void BinaryGap2147483646()
		{
			Assert.AreEqual(0, solution(2147483646));
		}

		[TestMethod]
		public void BinaryGap2147483647()
		{
			Assert.AreEqual(0, solution(2147483647));
		}

		[TestMethod]
		public void BinaryGap9()
		{
			Assert.AreEqual(2, solution(9));
		}

	}
}