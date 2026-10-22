using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProblems
{
    public  class FibanacciSeries
    {
        public FibanacciSeries()
        {
        }

        public static int fibonacceSeries(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        // Using Recursion
        public static int FibonacciRecursive(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        //using Memoization
        private static Dictionary<int, int> memo = new Dictionary<int, int>();
        public static int FibonacciMemoization(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            if (memo.ContainsKey(n))
            {
                return memo[n];
            }
            int result = FibonacciMemoization(n - 1) + FibonacciMemoization(n - 2);
            memo[n] = result;
            return result;
        }

        //tibonacci series using dynamic programming
        public static int FibonacciDynamicProgramming(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }

        
     


    }


}
