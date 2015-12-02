using System;
using System.Globalization;

namespace projecteuler.net.Problems
{
    internal class Problem10 : IProblem
    {
        public object Solve()
        {
            ulong sum = 0;
            for(int i = 2; i < 2e6; i++)
            {
                if(i.IsPrime())
                    sum += (ulong)i;
            }
            return sum;
        }
    }
}