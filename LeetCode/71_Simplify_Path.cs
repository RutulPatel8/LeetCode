namespace LeetCode
{
    public class _71_Simplify_Path
    {
        public static string SimplifyPath(string path)
        {
            var parts = path.Split("/", StringSplitOptions.RemoveEmptyEntries);

            Stack<string> stack = new Stack<string>();

            foreach (var item in parts)
            {
                if(item == ".")
                {
                    continue;
                }else if(item == "..")
                {
                    if(stack.Count > 0) {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(item);
                }
            }

            if (stack.Count == 0) return "/";

            return "/" + string.Join("/", stack.Reverse());
        }
    }
}
