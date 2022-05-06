using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    // Top down approach with memoization
    // Time: O(n) Space: O(n)
    public class Fibonacci
    {
        // Memoization approach
        // Time: O(n) Space: O(n)
        public static int FibonacciWithCache(int n)
        {
            int[] memo = new int[n + 1];
            return Fib(memo, n);
        }

        static int Fib(int[] memo, int n)
        {
            // base case
            if (n < 2) return n;

            if (memo[n] != 0) return memo[n];
            memo[n] = Fib(memo, n - 1) + Fib(memo, n - 2);
            return memo[n];
        }


        // Bottom up approach with dp
        // Time: O(n) Space: O(n)
        public static int FibDP(int n)
        {
            if (n == 0) return 0;
            int[] dp = new int[n + 1];

            // base case
            dp[0] = 0;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }

        // Bottom up approach with dp
        // Time: O(n) Space: O(1)
        public static int FibDPOptimized(int n)
        {
            if (n == 0 || n == 1)
                return n;

            int dp_i_1 = 1;
            int dp_i_2 = 0;

            for (int i = 2; i <= n; i++)
            {
                int dp_i = dp_i_1 + dp_i_2;
                dp_i_2 = dp_i_1;
                dp_i_1 = dp_i;
            }
            return dp_i_1;
        }
    }

}