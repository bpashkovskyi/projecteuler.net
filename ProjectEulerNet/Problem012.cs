namespace ProjectEulerNet
{
    internal class Problem012 : IProblem
    {
        public object Solve()
        {
            var current = 1;
            var i = 2;
            while (GetDividersCount(current) < 500)
            {
                current += i;
                i++;
            }
            return current;

        }

        private static int GetDividersCount(int number)
        {
            var dividersCount = 0;
            for (var i = 1; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    dividersCount++;
            }

            dividersCount *= 2;

            var sqrt = (int)Math.Sqrt(number);
            if (sqrt * sqrt == number)
            {
                dividersCount++;
            }

            return dividersCount;
        }
    }
}