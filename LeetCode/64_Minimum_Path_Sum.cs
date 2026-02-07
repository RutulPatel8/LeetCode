namespace LeetCode
{
    public class _64_Minimum_Path_Sum
    {
        public static int MinPathSum(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            int[,] dp = new int[m, n];
            dp[0, 0] = grid[0][0];

            //Intialize starting row
            for (int j = 1; j < n; j++)
            {
                dp[0, j] = dp[0, j - 1] + grid[0][j];
            }

            //Intialize starting col
            for (int i = 1; i < m; i++)
            {
                dp[i, 0] = dp[0, i - 1] + grid[i][0];
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i, j] = grid[i][j] + Math.Min(dp[i - 1, j], dp[i, j - 1]);
                }
            }

            return dp[m - 1, n - 1];
        }
    }
}
