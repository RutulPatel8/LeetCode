namespace LeetCode
{
    public class _643_Maximum_Average_Subarray_I
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            double windowSum = 0;
            double maxAverage = double.MinValue;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                windowSum += nums[i];

                if (i >= k-1)
                {
                    double average = windowSum / k;
                    maxAverage = Math.Max(maxAverage, average);
                    windowSum -= nums[i - (k - 1)];
                }
            }

            return Math.Round(maxAverage,5);
        }
    }
}
