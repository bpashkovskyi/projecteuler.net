namespace ProjectEulerNet
{
    // The prime factors of 13195 are 5, 7, 13 and 29.
    // What is the largest prime factor of the number 600851475143 ?
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