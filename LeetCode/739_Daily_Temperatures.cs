namespace LeetCode
{
    public class _739_Daily_Temperatures
    {
        public static int[] DailyTemperatures(int[] temperatures)
        {
            Stack<int> stack = new Stack<int>();
            int n = temperatures.Length;
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    int prevIndex = stack.Pop();
                    result[prevIndex] = i - prevIndex;
                }

                stack.Push(i);
            }

            return result;
        }
    }
}
