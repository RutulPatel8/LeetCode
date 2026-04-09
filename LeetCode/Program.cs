using LeetCode;


TreeNode root = new TreeNode(3);
root.left = new TreeNode(9);
root.right = new TreeNode(20);
root.right.left = new TreeNode(15);
root.right.right = new TreeNode(7);

var result = _104_Maximum_Depth_of_Binary_Tree.MaxDepth(root);
Console.WriteLine();