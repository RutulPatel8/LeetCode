namespace LeetCode
{
    public class _206_everse_inked_List
    {
        public static ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;

            while(curr != null)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }
    }
}
