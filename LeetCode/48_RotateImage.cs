namespace LeetCode
{
    public class _48_RotateImage
    {
        public static void Rotate(int[][] matrix)
        {
            int n = matrix.Length;

            // Step 1: Transpose
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            // Step 2: Reverse
            for (int i = 0; i < n; i++)
            {
                int left = 0, right = n - 1;
                while (left < right)
                {
                    Console.WriteLine($"Reverse row {i}: left={left}, right={right}");

                    int temp = matrix[i][left];
                    matrix[i][left] = matrix[i][right];
                    matrix[i][right] = temp;

                    left++;
                    right--;
                }
            }
        }
    }
}
