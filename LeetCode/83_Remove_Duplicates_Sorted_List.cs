namespace LeetCode
{
    public class _83_Remove_Duplicates_Sorted_List
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            var current = head;
            
            while(current != null && current.next != null)
            {
                if(current != null && current.next != null)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }

            return current;
        }
    }
}
