namespace LeetCode
{
    public class _45_JumpGameII
    {
        public int Jump(int[] nums)
        {
            int jump = 0;
            int farthest = 0;
            int currentEnd = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                farthest = Math.Max(farthest, i + nums[i]);

                if (i == currentEnd)
                {
                    jump++;
                    currentEnd = farthest;
                }
            }

            return jump;
        }
    }
}
