namespace LeetCode
{
    public class _21_MergeTwoSortedLists
    {
            public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                IList<int> finalList = new List<int>();
                finalList = GetList(list1);
                finalList = GetList(list2);

                var array = finalList.Order<int>().ToArray();
                ListNode finalNode = new ListNode(array[0], null);
                ListNode nextNode = finalNode;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i-1] != array[i]) {
                        nextNode.next = new ListNode(array[i], null);
                        nextNode = nextNode.next;
                    }
                }
            
                return finalNode;
            }

        public static int[] GetList(ListNode list1)
        {
            var list = new List<int>();
            FillList(list1, list);
            return list.ToArray();
        }

        private static void FillList(ListNode node, List<int> list)
        {
            if (node == null) return;

            list.Add(node.val);
            FillList(node.next, list);
        }
    }
}
