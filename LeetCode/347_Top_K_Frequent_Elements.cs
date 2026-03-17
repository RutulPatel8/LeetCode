namespace LeetCode
{
    public class _347_Top_K_Frequent_Elements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> freq = new();

            foreach (int num in nums)
                freq[num] = freq.GetValueOrDefault(num, 0) + 1;

            return freq
                .OrderByDescending(x => x.Value)
                .Take(k)
                .Select(x => x.Key)
                .ToArray();
        }
    }
}
