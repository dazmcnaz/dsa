namespace dsa_repo.Recursion
{
    public static class RecursionExamples
    {
        public static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            if (n <= 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

        public static int SumTo(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return n + SumTo(n - 1);
        }
    }
}
