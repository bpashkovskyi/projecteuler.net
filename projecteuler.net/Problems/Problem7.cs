using System;
using System.Globalization;

namespace projecteuler.net.Problems
{
    internal class Problem7 : IProblem
    {
        public object Solve()
        {
            var counter = 0;
            var p = 2;
            var prime = 0;
            while(counter < 10001)
            {
                if(p.IsPrime())
                {
                    counter++;
                    prime = p;
                }
                p++;
            }
            return prime;
        }
    }
}