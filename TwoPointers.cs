namespace Leetcode15Patterns
{
    static internal class TwoPointers
    {
        public static bool HasPairWithSum(int[] arr, int targetSum)
        {
            var left = 0;
            var right = arr.Length - 1;
            Array.Sort(arr); // Ensure the array is sorted

            while (left < right)
            {
                var currentSum = arr[left] + arr[right];
                if (currentSum == targetSum)
                {
                    return true;
                }
                if (currentSum < targetSum)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return false;
        }
    }
}
