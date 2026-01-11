namespace LeetCode
{
    public class _41_FirstMissingPositive
    {
        public static int FirstMissingPositive(int[] nums)
        {
            int n = nums.Length;

            // Step 1 & 2: Place each number in its correct position
            for (int i = 0; i < n; i++)
            {
                while (nums[i] > 0 &&
                       nums[i] <= n &&
                       nums[nums[i] - 1] != nums[i])
                {
                    int correctIndex = nums[i] - 1;

                    // swap nums[i] and nums[correctIndex]
                    int temp = nums[i];
                    nums[i] = nums[correctIndex];
                    nums[correctIndex] = temp;
                }
            }

            // Step 3: Find the first missing positive
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != i + 1)
                    return i + 1;
            }

            return n + 1;
        }
    }
}
