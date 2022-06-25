namespace ProjectEulerNet
{
    internal class Problem003 : IProblem
    {
        public object Solve()
        {
            const long p = 600851475143;
            long maxPrimeFactor = 1;
            for(var i = 2; i < Math.Sqrt(p); i++)
            {
                if(p % i == 0 && IsPrime(i))
                    maxPrimeFactor = i;
            }
            return maxPrimeFactor;
        }

        private static bool IsPrime(int p)
        {
            for (var i = 2; i <= Math.Sqrt(p); i++)
            {
                if (p % i == 0)
                    return false;
            }
            return true;
        }
    }
}