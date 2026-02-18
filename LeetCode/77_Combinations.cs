namespace LeetCode
{
    public class _77_Combinations
    {
        public IList<IList<int>> Combine(int[] nums, int k)
        {
            List<IList<int>> result = new List<IList<int>>();
            Backtrack(0, nums, k, new List<int>(), result);
            return result;
        }

        private void Backtrack(int start, int[] nums, int k,
                                      List<int> current,
                                      List<IList<int>> result)
        {
            if (current.Count == k)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = start; i < nums.Length; i++)
            {
                current.Add(nums[i]);
                Backtrack(i + 1, nums, k, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
