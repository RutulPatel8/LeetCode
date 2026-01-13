namespace LeetCode
{
    public class _44_Wildcard_Matching
    {
        public static bool IsMatch(string s, string p)
        {
            int m = s.Length, n = p.Length;

            if (m == 0)
            {
                foreach (var c in p) if (c != '*') return false;
                return true;
            }

            if (n == 0) return m == 0;
            bool[,] dp = new bool[m + 1, n + 1];
            dp[0, 0] = true;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < m; row++)
                    if (p[col] == '*')
                    {
                        dp[row, col + 1] |= dp[row, col];
                        dp[row + 1, col + 1] = dp[row, col + 1] || dp[row, col];
                    }
                    else if (p[col] == '?')
                        dp[row + 1, col + 1] = dp[row, col];
                    else
                        dp[row + 1, col + 1] = dp[row, col] && p[col] == s[row];
                if (p[col] == '*')
                    dp[m, col + 1] |= dp[m, col];
            }
            PrintMatrix(dp);
            return dp[m, n];
        }

        private static void PrintMatrix(bool[,] dp)
        {
            int rows = dp.GetLength(0);
            int cols = dp.GetLength(1);

            Console.WriteLine("DP Matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(dp[i, j] ? "T " : "F ");
                }
                Console.WriteLine();
            }
        }

    }
}
