using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProblems
{
    public class Missing_NumberFinder
    {
        // Find the missing number in an array containing numbers from 1 to n with one number missing
        public int FindMissingNumber(int[] nums, int n)
        {
            int expectedSum = n * (n + 1) / 2;
            int actualSum = nums.Sum();
            return expectedSum - actualSum;
        }

        // Using XOR
        public int FindMissingNumberWithXOR(int[] nums, int n)
        {
            int xorFull = 0;
            int xorArray = 0;
            for (int i = 1; i <= n; i++)
            {
                xorFull ^= i;
            }
            foreach (int num in nums)
            {
                xorArray ^= num;
            }
            return xorFull ^ xorArray;
        }

        // Using HashSet
        public int FindMissingNumberWithHashSet(int[] nums, int n)
        {
            HashSet<int> numSet = new HashSet<int>(nums);
            for (int i = 1; i <= n; i++)
            {
                if (!numSet.Contains(i))
                {
                    return i;
                }
            }
            return -1; // This should never happen if input is valid
        }

        // Using Boolean Array  
        public int FindMissingNumberWithBooleanArray(int[] nums, int n)
        {
            bool[] present = new bool[n + 1];
            foreach (int num in nums)
            {
                present[num] = true;
            }
            for (int i = 1; i <= n; i++)
            {
                if (!present[i])
                {
                    return i;
                }
            }
            return -1; // This should never happen if input is valid
        }

    }
}
