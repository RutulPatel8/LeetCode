using LeetCode;


ListNode _6thNode = new ListNode(6, null);
ListNode _5thNode = new ListNode(5, _6thNode);
ListNode _4thNode = new ListNode(4, _5thNode);
ListNode _3rdNode = new ListNode(3, _4thNode);
ListNode _2ndNode = new ListNode(2, _3rdNode);
ListNode _1stNode = new ListNode(1, _2ndNode);

_876_Middle_of_the_Linked_List.MiddleNode(_1stNode);
Console.WriteLine();