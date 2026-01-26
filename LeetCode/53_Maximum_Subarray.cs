namespace LeetCode
{
    public class _53_Maximum_Subarray
    {
        public static int MaxSubArray(int[] nums)
        {
            int currentSum = nums[0];
            int maxSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                currentSum = Math.Max(currentSum, currentSum + nums[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}
