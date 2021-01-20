using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace LinqQueryTest
{
	public class LinqMethod
	{
		[Test]
		public void Average()
		{
			var numbers1 = new List<int>() {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

			var average = numbers1.Average();

			Assert.AreEqual(4.5, average);
		}

		[Test]
		public void Concat()
		{
			var numbers1 = new List<int>() {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
			var numbers2 = new List<int>() {15, 14, 11, 13, 19, 18, 16, 17, 12, 10};

			var concatenationQuery = numbers1.Concat(numbers2);

			Assert.True(20 == concatenationQuery.Count());
		}

		[Test]
		public void Where()
		{
			var numbers2 = new List<int>() {15, 14, 11, 13, 19, 18, 16, 17, 12, 10};

			var largeNumbersQuery = numbers2.Where(c => c > 15);

			Assert.True(4 == largeNumbersQuery.Count());
		}
	}
}