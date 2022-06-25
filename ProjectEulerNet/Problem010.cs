namespace ProjectEulerNet
{
    internal class Problem010 : IProblem
    {
        public object Solve()
        {
            ulong sum = 0;
            for(var i = 2; i < 2e6; i++)
            {
                if(IsPrime(i))
                    sum += (ulong)i;
            }
            return sum;
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