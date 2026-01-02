namespace LeetCode
{
    public class _34_FindFirstLastPositionElementSortedArray
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) return [-1, -1];
            if (nums.Length == 1 && nums[0] == target) return [0, 0];

            int startIndex = 0;
            int endIndex = nums.Length-1;

            int finalSIndex = -1;
            int finalEIndex = -1;
            bool fSBooked = false;
            bool fEBooked = false;

            while (startIndex < endIndex)
            {
                if (nums[startIndex] == target)
                {
                    finalSIndex = startIndex;
                    fSBooked = true;
                }

                if (nums[endIndex] == target)
                {
                    finalEIndex = endIndex;
                    fEBooked = true;
                }


                if(!fSBooked) startIndex++;
                if(!fEBooked) endIndex--;
                if (fSBooked && fEBooked) break;
            }

            return [finalSIndex, finalEIndex];
        }
    }
}
