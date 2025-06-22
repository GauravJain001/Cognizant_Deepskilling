using System;
using System.Runtime.Intrinsics.Arm;
namespace code
{
    class Program
    {
        // Prediction (recursion) Formulae - (i-3)+(i-2)+(i-1)/2;
        private static Dictionary<int, float> data = new Dictionary<int, float>
        {
            {1, 4.5f},
            {2, 9.0f},
            {3, 2.5f}
        };
        private static Dictionary<int, float> dp = new Dictionary<int, float>
        {
            {1, 4.5f},
            {2, 9.0f},
            {3, 2.5f}

        };
        // Recursive method to predict value for a given year.
        // Time Complexity: O(3^n) - exponential,
        // because each call branches into 3 more calls unless cached.
        // Not efficient for large 'n' due to repeated recalculations.

        public static float predictRecursion(int year)
        {
            if (year <= 0)
            {
                return 0;
            }
            if (data.ContainsKey(year))
            {
                return data[year];
            }
            return (predictRecursion(year - 3) + predictRecursion(year - 2) + predictRecursion(year - 1)) / 2;
        }
        // Memoized (top-down DP) method to predict value for a given year.
        // Time Complexity: O(n)
        // Each year from 1 to 'n' is computed only once and stored in 'dp'.
        // Space Complexity: O(n) for the memoization dictionary.
        public static float predictMemoized(int year)
        {
            if (year <= 0)
            {
                return 0;
            }
            if (dp.ContainsKey(year))
            {
                return dp[year];
            }
            float val = (predictMemoized(year - 3) + predictMemoized(year - 2) + predictMemoized(year - 1)) / 2;
            dp.Add(year, val);
            return dp[year];
        }
        public static void Main(String[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                float rec = predictRecursion(i);
                float mem = predictMemoized(i);
                Console.WriteLine($"Year {i}: Recursive = {rec}, Memoized = {mem}");
            }

        }
    }
}