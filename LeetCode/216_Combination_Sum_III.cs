namespace LeetCode
{
    public class _216_Combination_Sum_III
    {
        public static IList<IList<int>> CombinationSum3(int k, int n)
        {
            var result = new List<IList<int>>();
            var current = new List<int>();

            void Backtrack(int start, int remaining)
            {
                if (remaining == 0 && current.Count == k)
                {
                    result.Add(new List<int>(current));
                    return;
                }

                if (remaining < 0 || current.Count > k)
                    return;

                for (int i = start; i <= 9; i++)
                {
                    if (i > remaining) break;

                    current.Add(i);

                    Backtrack(i + 1, remaining - i);

                    current.RemoveAt(current.Count - 1);
                }
            }

            Backtrack(1, n);
            return result;
        }
    }
}
