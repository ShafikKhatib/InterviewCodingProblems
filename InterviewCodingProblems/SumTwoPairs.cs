using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProblems
{
    public class SumTwoPairs
    {
        public SumTwoPairs() { }
        // Given an array of integers, find two pairs of integers such that the sum of the pairs is equal to a given target value.
        public List<(int, int, int, int)> FindTwoPairsWithSum(int[] nums, int target)
        {
            var result = new List<(int, int, int, int)>();
            var seenPairs = new Dictionary<int, List<(int, int)>>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int currentSum = nums[i] + nums[j];
                    int complement = target - currentSum;
                    if (seenPairs.ContainsKey(complement))
                    {
                        foreach (var pair in seenPairs[complement])
                        {
                            result.Add((pair.Item1, pair.Item2, nums[i], nums[j]));
                        }
                    }
                }
                for (int k = 0; k < i; k++)
                {
                    int pairSum = nums[k] + nums[i];
                    if (!seenPairs.ContainsKey(pairSum))
                    {
                        seenPairs[pairSum] = new List<(int, int)>();
                    }
                    seenPairs[pairSum].Add((nums[k], nums[i]));
                }
            }
            return result;
        }

        // Using HashSet to avoid duplicate pairs
        public List<(int, int, int, int)> FindTwoPairsWithSumHashSet(int[] nums, int target)
        {
            var result = new HashSet<(int, int, int, int)>();
            var seenPairs = new Dictionary<int, List<(int, int)>>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int currentSum = nums[i] + nums[j];
                    int complement = target - currentSum;
                    if (seenPairs.ContainsKey(complement))
                    {
                        foreach (var pair in seenPairs[complement])
                        {
                            var quad = (pair.Item1, pair.Item2, nums[i], nums[j]);
                            var sortedQuad = (Math.Min(Math.Min(quad.Item1, quad.Item2), Math.Min(quad.Item3, quad.Item4)),
                                              Math.Max(Math.Min(quad.Item1, quad.Item2), Math.Min(quad.Item3, quad.Item4)),
                                              Math.Min(Math.Max(quad.Item1, quad.Item2), Math.Max(quad.Item3, quad.Item4)),
                                              Math.Max(Math.Max(quad.Item1, quad.Item2), Math.Max(quad.Item3, quad.Item4)));
                            result.Add(sortedQuad);
                        }
                    }
                }
                for (int k = 0; k < i; k++)
                {
                    int pairSum = nums[k] + nums[i];
                    if (!seenPairs.ContainsKey(pairSum))
                    {
                        seenPairs[pairSum] = new List<(int, int)>();
                    }
                    seenPairs[pairSum].Add((nums[k], nums[i]));
                }
            }
            return result.ToList();
        }
    }
}
