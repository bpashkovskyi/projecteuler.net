namespace projecteuler.net.Problems
{
    internal class Problem2 : IProblem
    {
        public object Solve()
        {
            long sum = 2;

            var first = 1;
            var second = 2;
            var current = first + second;

            while(current < 4000000)
            {
                if(current % 2 == 0)
                    sum += current;

                first = second;
                second = current;
                current = first + second;
            }
            return sum;
        }
    }
}