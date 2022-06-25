namespace ProjectEulerNet
{
    internal class Problem014 : IProblem
    {
        public object Solve()
        {
            long maxChainLength = 0;
            long maxNumber = 0;
            for(long i = 1; i < 1000000; i++)
            {
                var chainLenght = 1;
                var currentNumber = i;
                while(currentNumber > 1)
                {
                    currentNumber = this.GetNext(currentNumber);
                    chainLenght++;
                }

                if(chainLenght > maxChainLength)
                {
                    maxChainLength = chainLenght;
                    maxNumber = i;
                }
            }
            return maxNumber;
        }

        private long GetNext(long previous)
        {
            return previous % 2 == 0
                ? previous / 2
                : 3 * previous + 1;
        }
    }
}