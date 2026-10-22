using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProblems
{
    public class RemoveDuplicate
    {
        public RemoveDuplicate() { }

        // Remove duplicates from an array and return the new length
        public RemoveDuplicate(string name) { }
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int writeIndex = 1;
            for (int readIndex = 1; readIndex < nums.Length; readIndex++)
            {
                if (nums[readIndex] != nums[readIndex - 1])
                {
                    nums[writeIndex] = nums[readIndex];
                    writeIndex++;
                }
            }
            return writeIndex;
        }

        // Using HashSet    
        public int RemoveDuplicatesWithHashSet(int[] nums)
        {
            if (nums == null) return 0;
            HashSet<int> uniqueNums = new HashSet<int>(nums);
            int index = 0;
            foreach (int num in uniqueNums)
            {
                nums[index] = num;
                index++;
            }
            return uniqueNums.Count;
        }

        // Using LINQ
        public int RemoveDuplicatesWithLinq(int[] nums)
        {
            if (nums == null) return 0;
            var uniqueNums = nums.Distinct().ToArray();
            Array.Copy(uniqueNums, nums, uniqueNums.Length);
            return uniqueNums.Length;
        }

        // Using SortedSet  
        public int RemoveDuplicatesWithSortedSet(int[] nums)
        {
            if (nums == null) return 0;
            SortedSet<int> uniqueNums = new SortedSet<int>(nums);
            int index = 0;
            foreach (int num in uniqueNums)
            {
                nums[index] = num;
                index++;
            }
            return uniqueNums.Count;
        }
    }
}
