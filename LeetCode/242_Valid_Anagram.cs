namespace LeetCode
{
    public class _242_Valid_Anagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> map = new();

            foreach (char c in s)
            {
                map[c] = map.GetValueOrDefault(c, 0) + 1;
            }

            foreach (char c in t)
            {
                if (!map.ContainsKey(c))
                    return false;

                map[c]--;

                if (map[c] < 0)
                    return false;
            }

            return true;
        }
    }
}
