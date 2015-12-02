using System;
using System.Globalization;

namespace projecteuler.net.Problems
{
    internal class Problem12 : IProblem
    {
        public object Solve()
        {
            int current = 1;
            int i = 2;
            while(GetDividersCount(current) < 500)
            {
                current += i;
                i++;
            }
            return current;

        }

        private int GetDividersCount(int number)
        {
            int dividersCount = 0;
            for(int i = 1; i < Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                    dividersCount++;
            }
            dividersCount = dividersCount * 2;
            int sqrt = (int)Math.Sqrt(number);
            if(sqrt * sqrt == number)
                dividersCount++;
            return dividersCount;
        }
    }
}