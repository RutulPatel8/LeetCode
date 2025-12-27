namespace LeetCode
{
    public class _17_LetterCombinationsPhoneNumber
    {
        public static IList<string> LetterCombinations(string digits)
        {
            IDictionary<string, string[]> letterCombination = new Dictionary<string, string[]>();
            letterCombination.Add("1", new string[] { });
            letterCombination.Add("2", new string[] { "a", "b", "c" });
            letterCombination.Add("3", new string[] { "d", "e", "f" });
            letterCombination.Add("4", new string[] { "g", "h", "i" });
            letterCombination.Add("5", new string[] { "j", "k", "l" });
            letterCombination.Add("6", new string[] { "m", "n", "o" });
            letterCombination.Add("7", new string[] { "p", "q", "r", "s" });
            letterCombination.Add("8", new string[] { "t", "u", "v" });
            letterCombination.Add("9", new string[] { "w", "x", "y", "z" });

            char[] totalChar = digits.ToCharArray();
            List<string> makeCombination = new List<string>();
            string[] iArray = null;
            List<string[]> listArry = new List<string[]>();
            for (int i = 0; i < totalChar.Length; i++)
            {
                letterCombination.TryGetValue(totalChar[i].ToString(), out iArray);
                if(iArray != null)
                {
                    makeCombination = CreateCombination(iArray.ToList(), makeCombination);
                }
            }

            return makeCombination;
        }

        public static List<string> CreateCombination(List<string> comb1, List<string> comb2)
        {
            List<string> finalList = new List<string>();
            bool firstPlace = comb2.Count == 0;
            foreach (var item in comb1)
            {
                if (firstPlace) { finalList.Add(item.ToString()); }
                foreach (var subItem in comb2)
                {
                    finalList.Add(subItem + item);
                }
            }

            return finalList;
        }
    }
}
