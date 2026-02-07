namespace LeetCode
{
    public class _67_Add_Binary
    {
        public static string AddBinary(string a, string b)
        {
            int maxLength = Math.Max(a.Length, b.Length);

            a = a.PadLeft(maxLength, '0');
            b = b.PadLeft(maxLength, '0');
            string finalString = string.Empty;
            char carry = '0';
            for (int i = maxLength - 1; i >= 0; i--)
            {
                if(a[i] == '1' &&  b[i] == '1')
                {
                    if(carry == '1')
                    {
                        carry = '1';
                        finalString = '1' + finalString;
                    }
                    else
                    {
                        carry = '1';
                        finalString = '0' + finalString;
                    }
                }

                if ((a[i] == '1' && b[i] == '0') || (a[i] == '0' && b[i] == '1'))
                {
                    if (carry == '1')
                    {
                        carry = '1';
                        finalString = '0' + finalString;
                    }
                    else
                    {
                        finalString = '1' + finalString;
                    }
                }

                if (a[i] == '0' && b[i] == '0')
                {
                    if (carry == '1')
                    {
                        finalString = '1' + finalString;
                        carry = '0';
                    }
                    else
                    {
                        finalString = '0' + finalString;
                    }   
                }
            }

            if(carry == '1')
            {
                finalString = '1' + finalString;
            }

            return finalString;
        }
    }
}
