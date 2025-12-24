namespace LeetCode
{
    public class _26_RemoveDuplicatesfromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            Stack<int> finalArray = new Stack<int>();

            foreach (var item in nums)
            {
                if(finalArray.Count() == 0 || finalArray.First() != item)
                {
                    finalArray.Push(item);
                }
            }


            return finalArray.Count();
        }
    }
}
