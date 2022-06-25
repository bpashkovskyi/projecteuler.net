namespace ProjectEulerNet
{
    using System.Diagnostics;

    class Program
    {
        static void Main()
        {
            IProblem problem = new Problem020();

            var stopWatch = Stopwatch.StartNew();

            var result = problem.Solve();
            
            stopWatch.Stop();

            Console.WriteLine(result);
            Console.ReadKey(true);
        }
    }
}
