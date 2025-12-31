namespace LeetCode
{
    public class _25_ReverseNodesGroup
    {
        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode current = dummy.next;
            ListNode prev = null;
            ListNode groupPrev = null;

            int i = 1;
            int j = 0;
            int l = 0;
            ListNode lastNode; 
            Stack<ListNode> linkNodes = new Stack<ListNode>();
            while(current != null)
            {
                if(i < k / 2 + 1)
                {
                    linkNodes.Push(current);
                }
                else
                {
                    if(j == 0 && k%2 != 0){

                    }
                    else
                    {
                        ListNode first = linkNodes.First<ListNode>();
                        ListNode second = current;
                        ListNode temp = first.next;

                        first.next = second.next;
                        second.next = temp;
                        prev.next = first;
                        current = first;

                        if(groupPrev != null)
                        {
                            groupPrev.next = second;
                        }

                        if(l == 0)
                        {
                            dummy.next = second;
                            l++;
                        }
           
                        linkNodes.Pop();
                    }
                    j++;
                }

                if (i == k)
                {
                    groupPrev = current;
                    linkNodes.Clear();
                    i = 0;
                    j = 0;
                }

                prev = current;
                current = current.next;
                i++;
            }

                
            return head;
        }
    }
}
