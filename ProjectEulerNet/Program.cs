namespace ProjectEulerNet
{
    using System.Diagnostics;

    class Program
    {
        static void Main()
        {
            IProblem problem = new Problem001();

            var stopWatch = Stopwatch.StartNew();

            var result = problem.Solve();
            
            stopWatch.Stop();

            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Execution time: {stopWatch.Elapsed.TotalMilliseconds} ms.");
            Console.ReadKey(true);
        }
    }
}
