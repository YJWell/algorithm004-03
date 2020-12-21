
public class Solution
{
    public IList<int> Preorder(Node root)
    {
        var result = new List<int>();
        _PreOrder(root, result);
        return result;
    }

    private void _PreOrder(Node node, IList<int> result)
    {
        if (node is null)
            return;
        result.Add(node.val);
        foreach (var child in node.children)
        {
            _PreOrder(child, result);
        }
    }
}

