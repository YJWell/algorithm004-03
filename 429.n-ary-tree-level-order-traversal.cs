/*
 * @lc app=leetcode id=429 lang=csharp
 *
 * [429] N-ary Tree Level Order Traversal
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node(){}
    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/
using System.Collections.Generic;
public class Solution
{

    public IList<IList<int>> LevelOrder(Node root)
    {
        var result = new List<IList<int>>();
        _LevelOrder(root, 0, result);
        return result;
    }

    private void _LevelOrder(Node node, int level, IList<IList<int>> result)
    {
        if (node is null)
        {
            return;
        }

        if (level + 1 > result.Count())
        {
            result.Add(new List<int>());
        }

        result[level++].Add(node.val);

        foreach (var child in node.children)
        {
            _LevelOrder(child, level, result);
        }
    }


}
// @lc code=end

