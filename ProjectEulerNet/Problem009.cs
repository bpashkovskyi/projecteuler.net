namespace ProjectEulerNet
{
    internal class Problem009 : IProblem
    {
        public object Solve()
        {
            for(var a = 1; a < 500; a++)
            {
                for(var b = 1; b < 500; b++)
                {
                    var c = 1000 - a - b;
                    if(this.IsTriangle(a, b, c))
                        return a * b * c;
                }
            }
            return "Error";
        }

        private bool IsTriangle(int a, int b, int c)
        {
            return a * a + b * b == c * c;
        }
    }
}