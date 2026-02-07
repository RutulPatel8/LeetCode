namespace LeetCode
{
    public class _61_Rotate_List
    {
        public static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) return head;
            ListNode traverseNode = head;
            int count = 0;
            for (int i = 0; i < k; i++)
            {
                count = 0;
                ListNode t = head;
                ListNode prv = head;
                while(t.next != null)
                {
                    prv = t;
                    t = t.next;
                    count++;
                }
                count++;

                if (count < k)
                {
                    k = k % count;

                    if (k == 0) return head;
                }

                t.next = head;
                prv.next = null;
                head = t;
            }

            return head;
        }
    }
}
