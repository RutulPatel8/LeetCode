using System.Linq;

namespace LeetCode
{
    public class _49_GroupAnagrams
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IDictionary<ReadOnlyMemory<char>, List<string>> keyValuePairs = new Dictionary<ReadOnlyMemory<char>, List<string>>();

            foreach (var item in strs)
            {
                char[] allChar = item.ToCharArray();
                bool isSetup = false;

                foreach (var keyValue in keyValuePairs)
                {
                    if (VerifyCharacter(allChar, keyValue))
                    {
                        keyValue.Value.Add(item);
                        isSetup = true;
                        break;
                    }
                }

                if (!isSetup)
                {
                    keyValuePairs.Add(allChar, new List<string>() { item });
                }
            }

            return keyValuePairs.Values.Cast<IList<string>>().ToList();
        }

        private static bool VerifyCharacter(
            char[] allChar,
            KeyValuePair<ReadOnlyMemory<char>, List<string>> keyValue)
        {
            // Fast length check
            if (allChar.Length != keyValue.Key.Length)
                return false;

            // Frequency array for 'a'–'z'
            Span<int> freq = stackalloc int[26];

            // Count from allChar
            foreach (char c in allChar)
            {
                int index = c - 'a';
                if ((uint)index >= 26) return false; // safety check
                freq[index]++;
            }

            // Subtract using keyValue
            foreach (char c in keyValue.Key.Span)
            {
                int index = c - 'a';
                if ((uint)index >= 26 || --freq[index] < 0)
                    return false;
            }

            return true;
        }


    }
}
