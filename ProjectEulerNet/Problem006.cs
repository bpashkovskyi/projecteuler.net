namespace ProjectEulerNet
{
    internal class Problem006 : IProblem
    {
        public object Solve()
        {
            return this.SqrSum(100) - this.SumSqr(100);
        }

        private long SqrSum(int count)
        {
            long sum = 0;
            for (var i = 0; i <= count; i++)
                sum += i;
            return sum * sum;
        }

        private long SumSqr(int count)
        {
            long sum = 0;
            for (var i = 0; i <= count; i++)
                sum += i * i;
            return sum;
        }
    }
}