namespace ProjectEulerNet
{
    internal class Problem004 : IProblem
    {
        public object Solve()
        {
            var maxPalindrome = 0;
            for (var i = 100; i < 1000; i++)
            {
                for (var j = i; j < 1000; j++)
                {
                    var ij = i * j;
                    if (this.IsPalindrom(ij.ToString()) && ij > maxPalindrome)
                        maxPalindrome = ij;
                }
            }
            return maxPalindrome;
        }

        private bool IsPalindrom(string input)
        {
            return input.Equals(this.Reverse(input));
        }

        private string Reverse(string input)
        {
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}