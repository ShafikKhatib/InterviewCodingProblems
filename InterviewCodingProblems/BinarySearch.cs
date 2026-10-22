using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProblems
{
    public class BinarySearch
    {
        public BinarySearch() { }

        public int BinarySeachIterative(int[] start, int end)
        {
            int left = 0;
            int right = start.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (start[mid] == end)
                    return mid;

                if (start[mid] < end)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1; //Not found
        }
    }
}
