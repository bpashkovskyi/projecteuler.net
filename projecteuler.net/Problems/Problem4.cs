using System;
using System.Globalization;

namespace projecteuler.net.Problems
{
    internal class Problem4 : IProblem
    {
        public object Solve()
        {
            var maxPalindrome = 0;
            for(int i = 100; i < 1000; i++)
            {
                for(int j = i; j < 1000; j++)
                {
                    var ij = i * j;
                    if(IsPalindrom(ij.ToString()) && ij > maxPalindrome)
                        maxPalindrome = ij;
                }
            }
            return maxPalindrome;
        }

        private bool IsPalindrom(string input)
        {
            return input.Equals(Reverse(input));
        }

        private string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}