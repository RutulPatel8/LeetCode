namespace LeetCode
{
    public class _31_NextPermutation
    {
        public static void NextPermutation(int[] nums)
        {
            int n = nums.Length;

            // 1️⃣ Find pivot
            int i = n - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            // 2️⃣ Find successor and swap
            if (i >= 0)
            {
                int j = n - 1;
                while (nums[j] <= nums[i])
                {
                    j--;
                }
                Swap(nums, i, j);
            }

            // 3️⃣ Reverse suffix
            Reverse(nums, i + 1, n - 1);
        }

        static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        static void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                Swap(nums, start, end);
                start++;
                end--;
            }
        }
    }
}
