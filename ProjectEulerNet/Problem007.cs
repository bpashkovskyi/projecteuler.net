namespace ProjectEulerNet
{
    internal class Problem007 : IProblem
    {
        public object Solve()
        {
            var counter = 0;
            var p = 2;
            var prime = 0;
            while(counter < 10001)
            {
                if(IsPrime(p))
                {
                    counter++;
                    prime = p;
                }
                p++;
            }
            return prime;
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