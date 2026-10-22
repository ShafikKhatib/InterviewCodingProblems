using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProblems
{
    public class LinqQueryOnMInMaxandOthers
    {
        // Find the minimum and maximum values in an array using LINQ
        public (int min, int max) FindMinMaxWithLinq(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                throw new ArgumentException("Array cannot be null or empty");
            int min = nums.Min();
            int max = nums.Max();
            return (min, max);
        }

        // Find the average value in an array using LINQ
        public double FindAverageWithLinq(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                throw new ArgumentException("Array cannot be null or empty");
            return nums.Average();
        }

        // Find the sum of all elements in an array using LINQ
        public int FindSumWithLinq(int[] nums)
        {
            if (nums == null)
                throw new ArgumentException("Array cannot be null");
            return nums.Sum();
        }

        // Find the count of elements in an array using LINQ
        public int FindCountWithLinq(int[] nums)
        {
            if (nums == null)
                throw new ArgumentException("Array cannot be null");
            return nums.Count();
        }

        // Find the distinct elements in an array using LINQ    
        public int[] FindDistinctWithLinq(int[] nums)
        {
            if (nums == null)
                throw new ArgumentException("Array cannot be null");
            return nums.Distinct().ToArray();
        }

        // Find the elements greater than a specified value using LINQ

        public int[] FindElementsGreaterThanWithLinq(int[] nums, int value)
        {
            if (nums == null)
                throw new ArgumentException("Array cannot be null");
            return nums.Where(n => n > value).ToArray();
        }

        // Find the elements less than a specified value using LINQ
        public int[] FindElementsLessThanWithLinq(int[] nums, int value)
        {
            if (nums == null)
                throw new ArgumentException("Array cannot be null");
            return nums.Where(n => n < value).ToArray();
        }

        // Find the elements equal to a specified value using LINQ
        public int[] FindElementsEqualToWithLinq(int[] nums, int value)
        {
            if (nums == null)
                throw new ArgumentException("Array cannot be null");
            return nums.Where(n => n == value).ToArray();
        }

        // Find the first n elements in an array using LINQ
        public int[] FindFirstNElementsWithLinq(int[] nums, int n)
        {
            if (nums == null)
                throw new ArgumentException("Array cannot be null");
            if (n < 0)
                throw new ArgumentException("n cannot be negative");
            return nums.Take(n).ToArray();
        }

        // Find the last n elements in an array using LINQ
        public int[] FindLastNElementsWithLinq(int[] nums, int n)
        {
            if (nums == null)
                throw new ArgumentException("Array cannot be null");
            if (n < 0)
                throw new ArgumentException("n cannot be negative");
            return nums.Skip(Math.Max(0, nums.Length - n)).ToArray();
        }

        // Find the elements at even indices in an array using LINQ
        public int[] FindElementsAtEvenIndicesWithLinq(int[] nums)
        {
            if (nums == null)
                throw new ArgumentException("Array cannot be null");
            return nums.Where((value, index) => index % 2 == 0).ToArray();
        }

        // Find the elements at odd indices in an array using LINQ
        public int[] FindElementsAtOddIndicesWithLinq(int[] nums)
        {
            if (nums == null)
                throw new ArgumentException("Array cannot be null");
            return nums.Where((value, index) => index % 2 != 0).ToArray();
        }

        // Find the top n maximum elements in an array using LINQ
        public int[] FindTopNMaxElementsWithLinq(int[] nums, int n)
        {
            if (nums == null)
                throw new ArgumentException("Array cannot be null");
            if (n < 0)
                throw new ArgumentException("n cannot be negative");
            return nums.OrderByDescending(x => x).Take(n).ToArray();
        }

        // Find the top n minimum elements in an array using LINQ
        public int[] FindTopNMinElementsWithLinq(int[] nums, int n)
        {
            if (nums == null)
                throw new ArgumentException("Array cannot be null");
            if (n < 0)
                throw new ArgumentException("n cannot be negative");
            return nums.OrderBy(x => x).Take(n).ToArray();
        }

        // Find the range (max - min) of elements in an array using LINQ
        public int FindRangeWithLinq(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                throw new ArgumentException("Array cannot be null or empty");
            int min = nums.Min();
            int max = nums.Max();
            return max - min;
        }

        

    }
}