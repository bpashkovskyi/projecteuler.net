namespace ProjectEulerNet
{
    internal class Problem006 : IProblem
    {
        public object Solve()
        {
            return SqrSum(100) - SumSqr(100);
        }

        private static long SqrSum(int count)
        {
            long sum = 0;
            for (var i = 0; i <= count; i++)
                sum += i;
            return sum * sum;
        }

        private static long SumSqr(int count)
        {
            long sum = 0;
            for (var i = 0; i <= count; i++)
                sum += i * i;
            return sum;
        }
    }
}