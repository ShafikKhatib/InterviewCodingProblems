using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProblems
{
    public class TribonacciSeries
    {
        public TribonacciSeries() { }

        // Generate Tribonacci series up to n terms
        public static List<int> GenerateTribonacciSeries(int n)
        {
            List<int> tribonacci = new List<int>();
            if (n <= 0) return tribonacci;
            tribonacci.Add(0);
            if (n == 1) return tribonacci;
            tribonacci.Add(1);
            if (n == 2) return tribonacci;
            tribonacci.Add(1);
            for (int i = 3; i < n; i++)
            {
                int nextTerm = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
                tribonacci.Add(nextTerm);
            }
            return tribonacci;
        }

        // Get the nth Tribonacci number using recursion
        public static int TribonacciRecursive(int n)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;
            return TribonacciRecursive(n - 1) + TribonacciRecursive(n - 2) + TribonacciRecursive(n - 3);
        }

        // Get the nth Tribonacci number using iteration
        public static int TribonacciIterative(int n)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;
            int a = 0, b = 1, c = 1, d = 0;
            for (int i = 3; i <= n; i++)
            {
                d = a + b + c;
                a = b;
                b = c;
                c = d;
            }
            return d;
        }
    }
}
