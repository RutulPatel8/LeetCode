namespace LeetCode
{
    public class _54_Spiral_Matrix
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            var result = new List<int>();

            int i = 0, j = 0;
            int top = 0, bottom = matrix.Length - 1;
            int left = 0, right = matrix[0].Length - 1;

            int direction = 0; // 0→1→2→3

            while (top <= bottom && left <= right)
            {
                if (direction == 0) // Left → Right
                {
                    for (j = left; j <= right; j++)
                        result.Add(matrix[top][j]);

                    top++;
                }
                else if (direction == 1) // Top → Bottom
                {
                    for (i = top; i <= bottom; i++)
                        result.Add(matrix[i][right]);

                    right--;
                }
                else if (direction == 2) // Right → Left
                {
                    for (j = right; j >= left; j--)
                        result.Add(matrix[bottom][j]);

                    bottom--;
                }
                else if (direction == 3) // Bottom → Top
                {
                    for (i = bottom; i >= top; i--)
                        result.Add(matrix[i][left]);

                    left++;
                }

                direction = (direction + 1) % 4; // rotate direction
            }

            return result;
        }
    }
}
