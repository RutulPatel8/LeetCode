namespace LeetCode
{
    public class _16_SumClosest
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int closetSum = int.MaxValue;
            int currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if ((i + 3) > nums.Length) { continue; }
                currentSum = nums[i] + nums[i + 1] + nums[i + 2];

                if(Math.Abs(currentSum - target) < Math.Abs(closetSum - target))
                {
                    closetSum = currentSum;

                    if (currentSum == target) return currentSum;
                }
            }

            return closetSum;
        }
    }
}
