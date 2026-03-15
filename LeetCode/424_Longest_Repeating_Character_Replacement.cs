namespace LeetCode
{
    public class _424_Longest_Repeating_Character_Replacement
    {
        public static int CharacterReplacement(string s, int k)
        {
            int left = 0;
            int maxLength = 0;
            int maxFreq = 0;

            int[] freq = new int[26];

            for (int right = 0; right < s.Length; right++)
            {
                freq[s[right] - 'A']++;

                maxFreq = Math.Max(maxFreq, freq[s[right] - 'A']);

                while ((right - left + 1) - maxFreq > k)
                {
                    freq[s[left] - 'A']--;
                    left++;
                }

                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
