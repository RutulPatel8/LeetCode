namespace LeetCode
{
    public class _35_SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            if(nums.Length == 1)
            {
                return nums[0] <= target ? 0 : 2; 
            }

            int startIndex = 0;
            int endIndex = nums.Length - 1;
            while (startIndex < endIndex)
            {

                if (target <= nums[startIndex])
                {
                    return startIndex == 0 ? 0 : startIndex - 1;
                }

                if (target > nums[endIndex])
                {
                    return endIndex < nums.Length - 1 ? nums.Length : endIndex + 1;
                }


                if (target > nums[startIndex] && nums.Length > startIndex && target <= nums[startIndex + 1])
                {
                    return startIndex + 1;
                }

                if (target <= nums[endIndex] && target > nums[endIndex - 1])
                {
                    return target <= nums[endIndex] ? endIndex : endIndex + 1;
                }

                startIndex++;
                endIndex--;
            }

            return -1;
        }
    }
}
