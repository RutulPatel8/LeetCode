namespace LeetCode
{
    public class _40_CombinationSum
    {
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {

            var result = new List<IList<int>>();
            BackTrack(candidates, target, 0, new List<int>(), result);
            return result;
        }

        public static void BackTrack(int[] candidates, int target, int start, List<int> current, List<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1])
                    continue;

                if (candidates[i] > target)
                    continue;

                current.Add(candidates[i]);
                BackTrack(candidates, target - candidates[i], i + 1, current, result);

                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
