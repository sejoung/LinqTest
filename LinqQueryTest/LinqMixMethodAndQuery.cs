using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace LinqQueryTest
{
    public class LinqMixMethodAndQuery
    {
        [Test]
        public void Mix1()
        {
            var numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numCount = (from num in numbers
                where num < 3 || num > 7
                select num).Count();

            Assert.AreEqual(5, numCount);
        }

        [Test]
        public void Mix2()
        {
            var numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numbersQuery =
                from num in numbers
                where num < 3 || num > 7
                select num;

            var numCount = numbersQuery.Count();
            Assert.AreEqual(5, numCount);


        }

    }
}