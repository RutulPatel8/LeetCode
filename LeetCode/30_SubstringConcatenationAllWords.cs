namespace LeetCode
{
    public class _30_SubstringConcatenationAllWords
    {
        public static IList<int> FindSubstring(string s, string[] words)
        {
            int start = 0;
            int end = s.Length;

            int wordsize = String.Concat(words).Length;
            List<string> outputString = new List<string>();
            List<int> finalArray = new List<int>();
            Permute(words, 0, outputString);

            for (int i = 0; i < s.Length; i++)
            {
                if(start > end)
                {
                    break;
                }

                if(start+wordsize <= s.Length)
                {
                    string word1 = s.Substring(start, wordsize);
                    if (outputString.Contains(word1) && !finalArray.Contains(start)) { finalArray.Add(start); }
                }

                if(end >= wordsize)
                {
                    string word2 = s.Substring(end - wordsize, wordsize);
                    if (outputString.Contains(word2) && !finalArray.Contains(end - wordsize)) { finalArray.Add(end - wordsize); }
                }

                start++;
                end--;
            }

            return finalArray.OrderBy(x => x).ToList();
        }

        public static void Permute(string[] words, int start, List<string> result)
        {
            if (start == words.Length)
            {
                result.Add(string.Concat(words));
                return;
            }

            for (int i = start; i < words.Length; i++)
            {
                Swap(words, start, i);
                Permute(words, start + 1, result);
                Swap(words, start, i); // backtrack
            }
        }

        public static void Swap(string[] arr, int i, int j)
        {
            string temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
