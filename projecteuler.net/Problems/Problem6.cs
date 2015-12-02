using System;

namespace projecteuler.net.Problems
{
    internal class Problem6 : IProblem
    {
        public object Solve()
        {
            return SqrSum(100) - SumSqr(100);
        }

        private long SqrSum(int count)
        {
            long sum = 0;
            for(int i = 0; i <= count; i++)
                sum += i;
            return sum * sum;
        }

        private long SumSqr(int count)
        {
            long sum = 0;
            for(int i = 0; i <= count; i++)
                sum += i * i;
            return sum;
        }
    }
}