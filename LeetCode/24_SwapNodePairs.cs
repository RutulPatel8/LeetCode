namespace LeetCode
{
    public class _24_SwapNodePairs
    {
        public static ListNode SwapPairs(ListNode head)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode prev = dummy;

            while (prev.next != null && prev.next.next != null)
            {
                ListNode first = prev.next;
                ListNode second = first.next;

                // swap
                first.next = second.next;
                second.next = first;
                prev.next = second;

                // move forward
                prev = first;
            }

            return dummy.next;
        }
    }
}
