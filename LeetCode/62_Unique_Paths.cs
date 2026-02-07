namespace LeetCode
{
    public class _62_Unique_Paths
    {
        public static int UniquePaths(int m, int n)
        {
            int[,] memo = new int[m, n];
            return VisitNext(0, 0, m, n, memo);
        }

        public static int VisitNext(int x, int y, int m, int n, int[,] memo)
        {
            Console.WriteLine("{"+x+"}, {"+y+"}");
            if(x == m - 1 && y == n - 1) { return 1; }

            // out of bounds
            if (x >= m || y >= n)
                return 0;

            // ⭐ already computed
            if (memo[x, y] != 0)
                return memo[x, y];

            int right = VisitNext(x + 1, y, m, n, memo); 
            int down = VisitNext(x, y + 1, m, n, memo);

            memo[x, y] = right + down;

            return memo[x, y];
        }
    }
}
