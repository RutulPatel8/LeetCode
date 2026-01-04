namespace LeetCode
{
    public class _37_SudokuSolver
    {
        public void SolveSudoku(char[][] board)
        {
            Solve(board);
        }

        private bool Solve(char[][] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row][col] == '.')
                    {
                        for (char c = '1'; c <= '9'; c++)
                        {
                            if (IsValid(board, row, col, c))
                            {
                                board[row][col] = c;

                                if (Solve(board))
                                    return true;

                                board[row][col] = '.'; // backtrack
                            }
                        }
                        return false; // no valid number
                    }
                }
            }
            return true; // solved
        }

        private bool IsValid(char[][] board, int row, int col, char c)
        {
            for (int i = 0; i < 9; i++)
            {
                // Row
                if (board[row][i] == c) return false;

                // Column
                if (board[i][col] == c) return false;

                // 3x3 Box
                int boxRow = (row / 3) * 3 + i / 3;
                int boxCol = (col / 3) * 3 + i % 3;

                if (board[boxRow][boxCol] == c) return false;
            }
            return true;
        }
    }
}
