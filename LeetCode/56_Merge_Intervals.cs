namespace LeetCode
{
    public class _56_Merge_Intervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            var list = new List<(int start, int end)>();

            foreach (var interval in intervals)
            {
                int min = interval[0];
                int max = interval[1];

                int i = 0;
                while (i < list.Count)
                {
                    var curr = list[i];

                    // ✅ overlap condition
                    if (min <= curr.end && max >= curr.start)
                    {
                        // merge intervals
                        min = Math.Min(min, curr.start);
                        max = Math.Max(max, curr.end);

                        // remove old interval and re-check
                        list.RemoveAt(i);
                    }
                    else
                    {
                        i++;
                    }
                }

                // add merged interval
                list.Add((min, max));
            }

            // convert to int[][]
            return list
                .Select(x => new[] { x.start, x.end })
                .ToArray();
        }
    }
}
