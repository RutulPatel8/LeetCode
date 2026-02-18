namespace LeetCode
{
    public class _74_Search_2D_Matrix
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int yLength = matrix[0].Length - 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] <= target && matrix[i][yLength] >= target)
                {
                    for (int j = 0; j <= yLength; j++)
                    {
                        if(target == matrix[i][j])
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
