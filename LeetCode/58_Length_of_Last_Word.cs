namespace LeetCode
{
    public class _58_Length_of_Last_Word
    {
        public static int LengthOfLastWord(string s)
        {
            int lastIndex = 0;
            int x = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ') {
                    if (x > 0) { return x; }
                    else if (lastIndex == 0 || lastIndex - 1 == lastIndex) { lastIndex = i; continue; } 
                } else { x++; }
            }

            return 0;
        }
    }
}
