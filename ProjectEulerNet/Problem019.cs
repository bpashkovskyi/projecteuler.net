namespace ProjectEulerNet
{
    internal class Problem019 : IProblem
    {
        public object Solve()
        {
            var startDate = new DateTime(1901, 1, 1);
            var endDate = new DateTime(2000, 12, 31);

            var currentDate = startDate;
            var result = 0;
            
            while (currentDate <= endDate)
            {
                if (currentDate.Day == 1 && currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    result++;
                }

                currentDate = currentDate.AddDays(1);
            }

            return result;
        }
    }
}