namespace Leetcode15Patterns
{
    static public class PrefixSum
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

        // Subarray Sum Equals K
        public static int SubarraySumEqualsK(int[] nums, int k)
        {
            int count = 0;
            Dictionary<int, int> prefixMap = new()
            {
                [0] = 1// Base case: one way to have a prefix sum of 0
            };
            int currentPrefixSum = 0;

            foreach (var n in nums)
            {
                currentPrefixSum += n;
                if (prefixMap.TryGetValue(currentPrefixSum - k, out int foundValue ))
                {
                    count += foundValue;
                }

                prefixMap[currentPrefixSum] = prefixMap.ContainsKey(currentPrefixSum) ? prefixMap[currentPrefixSum]++ : 1;

            }
            return count;
        }
    }
}
