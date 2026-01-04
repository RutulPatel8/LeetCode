namespace LeetCode
{
    public class _35_Valid_Sudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.') continue;

                    // Row check
                    int k = j + 1;
                    while (k < 9)
                    {
                        if (board[i][j] == board[i][k])
                            return false;
                        k++;
                    }

                    // Column check
                    int z = i + 1;
                    while (z < 9)
                    {
                        if (board[i][j] == board[z][j])
                            return false;
                        z++;
                    }

                    // 3x3 box check
                    int boxRowStart = (i / 3) * 3;
                    int boxColStart = (j / 3) * 3;

                    for (int r = boxRowStart; r < boxRowStart + 3; r++)
                    {
                        for (int c = boxColStart; c < boxColStart + 3; c++)
                        {
                            if ((r != i || c != j) && board[i][j] == board[r][c])
                                return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
