/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
//hash
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        var map = new Dictionary<ListNode, int>();

        var node = head;
        int pos = 0;
        while (!(node is null))
        {
            if (map.ContainsKey(node))
                return true;
            map.Add(node, pos++);
            node = node.next;
        }
        return false;
    }
}

//double pointers
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head is null) return false;
        var slow = head;
        var fast = head.next;
        while (fast != null && fast.next != null)
        {
            if (slow == fast)
                return true;
            slow = slow.next;
            fast = fast.next.next;
        }
        return false;
    }
}



public class Solution
{
    public bool HasCycle(ListNode head)
    {
        var slow = head;
        var fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
                return true;
        }
        return false;
    }
}




public class Solution
{
    public bool HasCycle(ListNode head)
    {
        try
        {
            var slow = head;
            var fast = head.next;
            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return true;
        }
        catch
        {
            return false;
        }
    }
}