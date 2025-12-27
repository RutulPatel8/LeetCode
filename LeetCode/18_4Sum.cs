using System.Linq;

namespace LeetCode
{
    public class _18_4Sum
    {
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            

            IList<IList<int>> finalResult = new List<IList<int>>();
            Array.Sort(nums);
            int left = 0;
            int right = nums.Length;
            for (int first = 0; first < nums.Length - 3; first++)
            {
                if (first > 0 && nums[first] == nums[first - 1])
                {
                    continue;
                }

                for (int second = first + 1; second < nums.Length - 2; second++)
                {
                    if (second > first + 1 && nums[second] == nums[second - 1])
                    {
                        continue;
                    }

                    left = second + 1;
                    right = nums.Length - 1;

                    while (left < right)
                    {
                        long sum = (long) nums[first] + nums[second] + nums[left] + nums[right];

                        if (sum < target)
                        {
                            left++;
                        }
                        else if (sum > target)
                        {
                            right--;
                        }
                        else
                        {
                            finalResult.Add(new List<int> { nums[first], nums[second], nums[left], nums[right] });
                            left++;
                            right--;

                            while (left < right && nums[left] == nums[left - 1])
                            {
                                left++;
                            }

                            while (left < right && nums[right] == nums[right + 1])
                            {
                                right--;
                            }
                        }
                    }
                }
            }

            return finalResult;
        }
    }
}
