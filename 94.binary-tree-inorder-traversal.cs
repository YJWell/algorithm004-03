/*
 * @lc app=leetcode id=94 lang=csharp
 *
 * [94] Binary Tree Inorder Traversal
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {

        var result = new List<int>();
        _InorderTraversal(root, result);
        return result;



    }

    private void _InorderTraversal(TreeNode node, IList<int> result)
    {
        if (node is null)
            return;
        _InorderTraversal(node.left, result);
        result.Add(node.val);
        _InorderTraversal(node.right, result);
    }

}
// @lc code=end

