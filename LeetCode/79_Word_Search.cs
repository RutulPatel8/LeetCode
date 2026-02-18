namespace LeetCode
{
    public class _79_Word_Search
    {
        public bool Exist(char[][] board, string word)
        {
            int totalR = board.Length;
            int totalC = board[0].Length;

            for (int i = 0; i < totalR; i++)
            {
                for (int j = 0; j < totalC; j++)
                {
                    if (NextVisit(board, word, "", i, j, totalR, totalC, 0))
                        return true;
                }
            }

            return false;
        }

        public bool NextVisit(char[][] board, string Word, string outputWord, int rowIndex, int colIndex, int totalR, int totalC, int nextCharIndex)
        {
            if (nextCharIndex == Word.Length)
                return true;

            if (rowIndex < 0 || colIndex < 0 ||
                rowIndex >= totalR || colIndex >= totalC)
                return false;

            if (board[rowIndex][colIndex] != Word[nextCharIndex])
                return false;

            char temp = board[rowIndex][colIndex];
            board[rowIndex][colIndex] = '#';

            bool found =
                NextVisit(board, Word, outputWord + temp, rowIndex + 1, colIndex, totalR, totalC, nextCharIndex + 1) ||
                NextVisit(board, Word, outputWord + temp, rowIndex - 1, colIndex, totalR, totalC, nextCharIndex + 1) ||
                NextVisit(board, Word, outputWord + temp, rowIndex, colIndex + 1, totalR, totalC, nextCharIndex + 1) ||
                NextVisit(board, Word, outputWord + temp, rowIndex, colIndex - 1, totalR, totalC, nextCharIndex + 1);

            board[rowIndex][colIndex] = temp;

            return found;
        }
    }
}
