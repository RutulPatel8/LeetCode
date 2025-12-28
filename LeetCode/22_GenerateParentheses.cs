namespace LeetCode
{
    public class _22_GenerateParentheses
    {
        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            Stack<(string str, int open, int close)> stack = new Stack<(string, int, int)>();

            // Start with empty state
            stack.Push(("", 0, 0));

            while (stack.Count > 0)
            {
                var (current, open, close) = stack.Pop();

                // If complete, add to result
                if (current.Length == 2 * n)
                {
                    result.Add(current);
                    continue;
                }

                // Add ')' if valid
                if (close < open)
                {
                    stack.Push((current + ")", open, close + 1));
                }

                // Add '(' if we still can
                if (open < n)
                {
                    stack.Push((current + "(", open + 1, close));
                }
            }

            return result;
        }
    }
}
