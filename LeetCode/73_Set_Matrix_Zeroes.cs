namespace LeetCode
{
    public class _73_Set_Matrix_Zeroes
    {
        public static void SetZeroes(int[][] matrix)
        {
            List<int> cols = new List<int>();
            List<int> rows = new List<int>();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if (!cols.Contains(i))
                        {
                            cols.Add(i);
                            for (int iR = i; iR >= 0; iR--)
                            {
                                matrix[iR][j] = 0;
                            }
                        }

                        if (!rows.Contains(j))
                        {
                            rows.Add(j);

                            for (int jR = j; jR >= 0; jR--)
                            {
                                matrix[i][jR] = 0;
                            }
                        }
                    }

                    if (rows.Contains(j) || cols.Contains(i))
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
    }
}
