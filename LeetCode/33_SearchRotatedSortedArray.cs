namespace LeetCode
{
    public class _33_SearchRotatedSortedArray
    {
        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Found the target
                if (nums[mid] == target)
                    return mid;

                // Left part is sorted
                if (nums[left] <= nums[mid])
                {
                    // Target lies in the sorted left part
                    if (nums[left] <= target && target < nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                // Right part is sorted
                else
                {
                    // Target lies in the sorted right part
                    if (nums[mid] < target && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return -1; // Target not found
        }
    }
}
