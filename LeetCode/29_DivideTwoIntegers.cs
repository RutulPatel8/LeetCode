namespace LeetCode
{
    public class _29_DivideTwoIntegers
    {
        public static int Divide(int dividend, int divisor)
        {
            int finalSum = 0;
            int i = 0;
            while(finalSum < Math.Abs(dividend))
            {
                finalSum += Math.Abs(divisor);
                i++;
            }
            
            i--;
            return (dividend < 0 || divisor < 0) ? finalSum * -1 : finalSum;
        }
    }
}
