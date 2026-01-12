namespace LeetCode
{
    public class _43_MultiplyStrings
    {
        public static string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            int n = num1.Length;
            int m = num2.Length;

            int[] result = new int[n + m];

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    int mul = (num1[i] - '0') * (num2[j] - '0');
                    int sum = mul + result[i + j + 1];

                    result[i + j + 1] = sum % 10;
                    result[i + j] += sum / 10;
                }
            }

            var sb = new System.Text.StringBuilder();
            foreach (var item in result)
            {
                if (sb.Length == 0 && item == 0) continue;
                sb.Append(item);
            }

            return sb.Length == 0 ? "0" : sb.ToString();
        }
    }
}
