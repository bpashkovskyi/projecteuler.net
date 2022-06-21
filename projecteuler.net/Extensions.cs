namespace projecteuler.net
{
    static class Extensions
    {
        public static bool IsPrime(this int p)
        {
            for(var i = 2; i <= Math.Sqrt(p); i++)
            {
                if(p % i == 0)
                    return false;
            }
            return true;
        }
    }
}
