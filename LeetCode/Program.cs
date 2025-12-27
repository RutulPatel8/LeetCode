// See https://aka.ms/new-console-template for more information
using LeetCode;

Console.WriteLine("Hello, World!");
ListNode head = new ListNode(1, 
                        new ListNode(2, 
                            new ListNode(3,
                                new ListNode(4,
                                    new ListNode(5)))));

int n = 2;
ListNode result = _21_MergeTwoSortedLists.MergeTwoLists(head, head);
