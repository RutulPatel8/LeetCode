namespace LeetCode
{
    public class _63_Unique_Paths_II
    {
        public int UniquePathsWithObstacles(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            if (grid[0][0] == 1 || grid[m - 1][n - 1] == 1)
                return 0;

            int[,] memo = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    memo[i, j] = -1;

            return VisitNext(0, 0, grid, memo);
        }

        private static int VisitNext(int x, int y, int[][] grid, int[,] memo)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            if (x >= m || y >= n)
                return 0;

            if (grid[x][y] == 1)
                return 0;

            if (x == m - 1 && y == n - 1)
                return 1;

            if (memo[x, y] != -1)
                return memo[x, y];

            int right = VisitNext(x + 1, y, grid, memo);
            int down = VisitNext(x, y + 1, grid, memo);

            memo[x, y] = right + down;

            return memo[x, y];
        }
    }
}
