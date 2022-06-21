using projecteuler.net.Problems;

namespace projecteuler.net
{
    class Program
    {
        static void Main(string[] args)
        {
            IProblem problem = new Problem14();

            var startTime = DateTime.Now;
            var result = problem.Solve();
            var diff = DateTime.Now - startTime;
            Console.WriteLine(result);
            Console.WriteLine(diff);
            Console.ReadKey(true);
        }
    }
}
