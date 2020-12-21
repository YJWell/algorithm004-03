

//preorder dfs
//stack iteration
public class Solution
{
    public bool IsValidBST(TreeNode root)
    {

        var stack = new Stack<TreeNode>();
        var lowerStack = new Stack<int?>();
        var upperStack = new Stack<int?>();
        stack.Push(root);
        lowerStack.Push(null);
        upperStack.Push(null);

        while (stack.Count() > 0)
        {
            var node = stack.Pop();
            int? lowerBound = lowerStack.Pop();
            int? upperBound = upperStack.Pop();

            if (node is null) continue;
            if (lowerBound.HasValue && node.val <= lowerBound) return false;
            if (upperBound.HasValue && node.val >= upperBound) return false;
            stack.Push(node.right);
            stack.Push(node.left);

            lowerStack.Push(node.val); //right
            lowerStack.Push(lowerBound); //left

            upperStack.Push(upperBound); //right
            upperStack.Push(node.val); //left
        }
        return true;
    }
}

//preorder dfs
//recusive
public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        return _IsValidBST(root, null, null);
    }

    private bool _IsValidBST(TreeNode node, int? lowerBound, int? upperBound)
    {
        if (node is null)
            return true;
        if (upperBound.HasValue && node.val >= upperBound)
            return false;
        if (lowerBound.HasValue && node.val <= lowerBound)
            return false;
        return _IsValidBST(node.left, lowerBound, node.val)
         && _IsValidBST(node.right, node.val, upperBound);
    }
}

//inoder traversal - uttilize feature of inoder that it is increment sequence
//stack - note the differece of dfs by stack - preorder, inorder, postorder
public class Solution
{
    public bool IsValidBST(TreeNode root)
    {

        var stack = new Stack<TreeNode>();
        int? preVal = null;
        while (stack.Count() > 0 || root != null)
        {
            if (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
            else
            {
                root = stack.Pop();
                if (preVal.HasValue && root.val <= preVal.Value) return false;
                preVal = root.val;
                root = root.right;
            }
        }
        return true;
    }
}

//inoder traversal
//recursive
public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        return Inorder(root);

    }
    private int? preVal = null;
    private bool Inorder(TreeNode root)
    {
        if (root is null)
            return true;
        if (!Inorder(root.left)) return false;
        if (preVal.HasValue && root.val <= preVal.Value) return false;
        preVal = root.val;
        if (!Inorder(root.right)) return false;
        return true;
    }
}