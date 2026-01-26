namespace LeetCode
{
    public class _55_Jump_Game
    {
        public static bool CanJump(int[] nums)
        {
            int goal = nums.Length - 1;
            int max_jump = 0;
            
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                max_jump = nums[i];

                if(i + max_jump >= goal)
                {
                    goal = i;
                }
            }

            return goal == 0;
        }
    }
}
