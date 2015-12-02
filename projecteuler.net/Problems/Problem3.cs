using System;

namespace projecteuler.net.Problems
{
    internal class Problem3 : IProblem
    {
        public object Solve()
        {
            const long p = 600851475143;
            long maxPrimeFactor = 1;
            for(int i = 2; i < Math.Sqrt(p); i++)
            {
                if(p % i == 0 && i.IsPrime())
                    maxPrimeFactor = i;
            }
            return maxPrimeFactor;
        }
    }
}