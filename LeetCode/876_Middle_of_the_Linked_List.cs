namespace LeetCode
{
    public class _876_Middle_of_the_Linked_List
    {
        public static ListNode MiddleNode(ListNode head)
        {
            if (head == null) return head;

            ListNode fast = head;
            ListNode slow = head;

            do
            {
                slow = slow.next;
                if(fast.next != null)
                {
                    fast = fast.next.next;
                }
            } while (fast != null && fast.next.next != null);

            return slow;
        }
    }
}
