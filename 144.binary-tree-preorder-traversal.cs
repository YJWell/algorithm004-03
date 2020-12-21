/*
 * @lc app=leetcode id=144 lang=csharp
 *
 * [144] Binary Tree Preorder Traversal
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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        _ProOrderTraversal(root, result);
        return result;
    }

    private void _ProOrderTraversal(TreeNode node, IList<int> result)
    {
        if (node is null)
        {
            return;
        }
        result.Add(node.val);
        _ProOrderTraversal(node.left, result);
        _ProOrderTraversal(node.right, result);

    }
}
// @lc code=end

