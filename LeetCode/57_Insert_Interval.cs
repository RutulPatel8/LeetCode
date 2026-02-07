using System.Reflection;

namespace LeetCode
{
    public class _57_Insert_Interval
    {
        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var list = new List<int[]>();

            int newStart = newInterval[0];
            int newEnd = newInterval[1];


            foreach (var interval in intervals)
            {
                int start = interval[0];
                int end = interval[1];

                if (end < newStart)
                {
                    list.Add(interval);
                }
                else if (start > newEnd)
                {
                    list.Add(new[] { newStart, newEnd });
                    newStart = start;
                    newEnd = end;
                }
                else
                {
                    newStart = Math.Min(newStart, start);
                    newEnd = Math.Max(newEnd, end);
                }
            }

            list.Add(new[] { newStart, newEnd });

            return list.ToArray();
        }
    }
}
