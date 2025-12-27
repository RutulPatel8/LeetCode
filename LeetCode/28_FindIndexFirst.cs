namespace LeetCode
{
    public class _28_FindIndexFirst
    {
        public static int StrStr(string haystack, string needle)
        {
            char[] word = needle.ToCharArray();

            for(int i = 0; i <= haystack.Length; i++)
            {
                if (word[0] == haystack[i] && haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
