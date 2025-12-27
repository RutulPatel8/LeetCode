using System.Collections.Generic;

namespace LeetCode
{
    public class _19_RemoveNthNodeFromEndList
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next == null && n == 1) return null;
            var value = GetSpecificNodeFromLast(head, null, n);
            
            if(value.Item1 == -2) { return value.Item2; }
            return head;
        }

        public static (int,ListNode) GetSpecificNodeFromLast(ListNode listNode, ListNode prev, int n)
        {
            if(listNode.next != null)
            {
                (int,ListNode) node = GetSpecificNodeFromLast(listNode.next, listNode, n);

                if(node.Item1+1 == n)
                {
                    if (prev == null) return (-2, listNode.next);
                    prev.next = node.Item2;
                }

                return (++node.Item1, listNode);
            }
            else
            {
                if(n == 1) { prev.next = null; }
                return (1, listNode);
            }

            return (-1, null);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
