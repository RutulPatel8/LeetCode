namespace LeetCode
{
    public class _32_LongestValidParentheses
    {
        public static int LongestValidParentheses(string s)
        {
            Stack<int> longestPar = new Stack<int>();
            longestPar.Push(-1);


            char[] charArr = s.ToCharArray();
            int maxLength = 0;

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == '(')
                {
                    longestPar.Push(i);
                }
                else
                {
                    longestPar.Pop();
                    
                    if(longestPar.Count == 0)
                    {
                        longestPar.Push(i);
                    }
                    else
                    {
                        int currentLength = i - longestPar.Peek();
                        maxLength = Math.Max(maxLength, currentLength);
                    }
                }
            }

            return maxLength;
        }
    }
}
