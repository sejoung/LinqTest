using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace LinqQueryTest
{
    public class LinqQueryExpressions
    {
        [Test]
        public void 크기비교()
        {
            int[] scores = { 97, 92, 81, 60 };

            var scoreQuery =
                from score in scores
                where score > 80
                select score;

            foreach (var i in scoreQuery)
            {
                Assert.Greater(i, 80);
            }
        }

        [Test]
        public void 범위확인()
        {
            var numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var filteringQuery =
                from num in numbers
                where num < 3 || num > 7
                select num;


            foreach (var i in filteringQuery)
            {
                switch (i)
                {
                    case < 3:
                    case > 7:
                        Assert.Pass();
                        break;
                    default:
                        Assert.Fail();
                        break;
                }
            }
        }

        [Test]
        public void 정렬확인()
        {
            var numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var orderingQuery =
                from num in numbers
                where num < 3 || num > 7
                orderby num ascending
                select num;


            Assert.That(orderingQuery, Is.Ordered.Ascending);
        }

        [Test]
        public void 그룹핑확인()
        {
            string[] groupingQuery = { "carrots", "cabbage", "broccoli", "beans", "barley" };
            IEnumerable<IGrouping<char, string>> queryFoodGroups =
                from item in groupingQuery
                group item by item[0];

            foreach (var queryFoodGroup in queryFoodGroups)
            {
                var count = queryFoodGroup.Count();
                switch (queryFoodGroup.Key)
                {
                    case 'c':
                        Assert.AreEqual(2, count);
                        break;
                    case 'b':
                        Assert.AreEqual(3, count);
                        break;
                    default:
                        Assert.Fail();
                        break;
                }
            }


        }
    }
}