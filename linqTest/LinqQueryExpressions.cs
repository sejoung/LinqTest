using System;
using System.Collections.Generic;
using System.Linq;

namespace linqTest
{
    class LinqQueryExpressions
    {
        static void Main()
        {
            // Specify the data source.
            int[] scores = new int[] {97, 92, 81, 60};

            // Define the query expression.
            var scoreQuery =
                from score in scores
                where score > 80
                select score;

            Print(scoreQuery);

            var highScoresQuery =
                from score in scores
                where score > 80
                orderby score descending
                select score;

            Print(highScoresQuery);

            var highScoresQuery2 =
                from score in scores
                where score > 80
                orderby score descending
                select $"The score is {score}";

            Print(highScoresQuery2);
     
        }

        static void Print<T>(IEnumerable<T> scoreQuery)
        {

            foreach (var i in scoreQuery)
            {
                Console.WriteLine(i);
            }
        }
    }
}