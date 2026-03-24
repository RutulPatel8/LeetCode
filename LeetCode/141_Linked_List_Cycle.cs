namespace LeetCode
{
    public class _141_Linked_List_Cycle
    {
        public static bool HasCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(slow.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if(slow == fast) return true;
            }

            return false;
        }
    }
}
