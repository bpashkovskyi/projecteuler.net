namespace ProjectEulerNet;

internal class Problem020 : IProblem
{
    public object Solve()
    {
        int n = 20;
        long prod = 1;

        for (var i = 1; i <= n; i++)
        {
            prod *= i;
            if (prod % 10 == 0)
            {
                prod /= 10;
            }
        }

        return prod;
    }



    private long SumN(long number)
    {
        long sum = 0;

        while (number > 0)
        {
            long mod = number % 10;
            sum += mod;
            number = (number - mod) / 10;
        }

        return sum;
    }
}