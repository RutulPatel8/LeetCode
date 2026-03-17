namespace LeetCode
{
    public class _349_Intersection_of_Two_Arrays
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> hashSet = nums1.ToHashSet<int>();

            HashSet<int> result = new HashSet<int>();

            foreach (var item in nums2)
            {
                if (hashSet.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
    }
}
