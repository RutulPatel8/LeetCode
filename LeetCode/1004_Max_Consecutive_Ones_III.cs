namespace LeetCode
{
    public class _1004_Max_Consecutive_Ones_III
    {
        public static int LongestOnes(int[] nums, int k)
        {
            int left = 0;
            int zeroCount = 0;
            int maxLength = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    zeroCount++;
                }

                while(zeroCount > k)
                {
                    if (nums[left] == 0)
                    {
                        zeroCount--;
                    }

                    left++;
                }

                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
