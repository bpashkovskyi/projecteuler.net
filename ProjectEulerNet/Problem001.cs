namespace ProjectEulerNet
{
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    // Find the sum of all the multiples of 3 or 5 below 1000.
    internal class Problem001 : IProblem
    {
        public object Solve()
        {
            var target = 999;

            return SumDivisibleBy(3)(target) + SumDivisibleBy(5)(target) - SumDivisibleBy(15)(target);
        }

        private static Func<int, int> SumDivisibleBy(int n)
        {
            return target =>
            {
                var p = target / n;
                return n * (p * (p + 1)) / 2;
            };
        }
    }
}