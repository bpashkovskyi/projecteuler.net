﻿namespace ProjectEulerNet
{
    internal class Problem018 : IProblem
    {
        public object Solve()
        {
            var triangle = new[]
            {
                new[] { 75 },
                new[] { 95, 64 },
                new[] { 17, 47, 82 },
                new[] { 18, 35, 87, 10 },
                new[] { 20, 04, 82, 47, 65 },
                new[] { 19, 01, 23, 75, 03, 34 },
                new[] { 88, 02, 77, 73, 07, 63, 67 },
                new[] { 99, 65, 04, 28, 06, 16, 70, 92 },
                new[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 },
                new[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 },
                new[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 },
                new[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 },
                new[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 },
                new[] { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 },
                new[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 }
            };

            for (var row = triangle.Length - 2; row >= 0; row--)
            {
                for (var rowElement = 0; rowElement < triangle[row].Length; rowElement++)
                {
                    var possibleWays = new List<int> { triangle[row + 1][rowElement], triangle[row + 1][rowElement + 1] };

                    triangle[row][rowElement] += possibleWays.Max();
                }
            }

            return triangle[0][0];
        }
    }
}