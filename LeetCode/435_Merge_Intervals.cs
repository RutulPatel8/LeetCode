namespace LeetCode
{
    public class _435_Merge_Intervals
    {
        public static int EraseOverlapIntervals(int[][] intervals = null)
        {
            if (intervals.Length == 0)
                return 0;

            Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

            int count = 1; 
            int prevEnd = intervals[0][1];

            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] >= prevEnd)
                {
                    count++;
                    prevEnd = intervals[i][1];
                }
            }

            return intervals.Length - count;
        }
    }
}
