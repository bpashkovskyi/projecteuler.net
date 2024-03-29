﻿namespace ProjectEulerNet
{
    // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    // Find the largest palindrome made from the product of two 3-digit numbers.
    internal class Problem004 : IProblem
    {
        public object Solve()
        {
            var maxPalindrome = 0;
            for (var i = 100; i < 1000; i++)
            {
                for (var j = i; j < 1000; j++)
                {
                    var ij = i * j;
                    if (IsPalindrom(ij.ToString()) && ij > maxPalindrome)
                        maxPalindrome = ij;
                }
            }
            return maxPalindrome;
        }

        private static bool IsPalindrom(string input)
        {
            return input.Equals(input.Reverse());
        }
    }
}