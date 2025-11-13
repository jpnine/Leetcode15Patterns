using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode15Patterns
{
    static internal class PrefixSum
    {
        /// <summary>
        /// Find the sum of elements between indices a and b (inclusive) in the given array using Prefix Sum technique.
        /// </summary>
        /// <param name="nums">Input Array</param>
        /// <param name="a">First Index</param>
        /// <param name="b">Second Index</param>
        /// <returns></returns>
        public static int CalculatePrefixSum(int[] nums, int a, int b)
        {
            int n = nums.Length;
            int[] prefixSums = new int[n + 1];
            prefixSums[0] = 0;
            // Time Complexity: O(n) to build the prefix sums , for subarray O(1) , Space Complexity: O(n) for the prefix sums array
            for (int i = 0; i < n; i++)
            {
                prefixSums[i + 1] = prefixSums[i] + nums[i];
            }
            return prefixSums[b + 1] - prefixSums[a];
        }
    }
}
