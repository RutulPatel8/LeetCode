namespace LeetCode
{
    public class _86_Partition_List
    {
        public static ListNode Partition(ListNode head, int x)
        {

            ListNode beforeDummy = new ListNode(0);
            ListNode afterDummy = new ListNode(0);

            ListNode before = beforeDummy;
            ListNode after = afterDummy;

            while (head != null)
            {
                if(head.val < 0)
                {
                    before.next = head;
                    before = before.next;
                }
                else
                {
                    after.next = head;
                    after = after.next;
                }

                head = head.next;
            }

            after.next = null;

            before.next = afterDummy.next;

            return beforeDummy.next;
        }
    }
}
