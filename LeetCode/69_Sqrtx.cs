namespace LeetCode
{
    public class _69_Sqrtx
    {
        public static int MySqrt(int x)
        {

            int left = 1;
            int right = x;
            int ans = 0;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Avoid overflow: instead of mid * mid
                if (mid <= x / mid)
                {
                    ans = mid;        // store possible answer
                    left = mid + 1;   // try to find bigger one
                }
                else
                {
                    right = mid - 1;  // reduce range
                }
            }

            return ans;
        }
    }
}
