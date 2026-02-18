namespace LeetCode
{
    public class _78_Subsets
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Backtrack(0, nums, new List<int>(), result);
            return result;
        }

        private static void Backtrack(int start, int[] nums, List<int> current, IList<IList<int>> result)
        {
            result.Add(new List<int>(current));

            for (int i = start; i < nums.Length; i++)
            {
                current.Add(nums[i]);

                Backtrack(i + 1, nums, current, result);

                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
