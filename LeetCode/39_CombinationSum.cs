namespace LeetCode
{
    public class _39_CombinationSum
    {
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> finalResult = new List<IList<int>>();

            var finalCandidates = candidates.ToList().Where(x => target > x);

            var itSelfCandidate = candidates.Any(x => x == target);
            if (itSelfCandidate)
            {
                finalResult.Add(new List<int>(target));
            }

            int i = 0;
            var result = target;
            var finalCanArr = finalCandidates.OrderByDescending(x => x).ToArray();
            while (i < finalCandidates.Count())
            {
                result = result - finalCanArr[i];



                if(result < finalCanArr[i])
                {
                    i++;
                }
            }

            return finalResult;
        }
    }
}
