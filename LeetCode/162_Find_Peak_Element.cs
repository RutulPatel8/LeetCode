namespace LeetCode
{
    public class _162_Find_Peak_Element
    {
        public static int FindPeakElement(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0) { if (i + 1 <= nums.Length - 1 && nums[i] > nums[i + 1]) { return i; } continue; }
                if (i == nums.Length-1) { if (nums[i] > nums[i - 1]) { return i; } continue; }
                if (nums[i] > nums[i-1] && nums[i] > nums[i+1]) { return i; }
            }

            return 0;
        }
    }
}
