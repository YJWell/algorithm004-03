/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{

    public ListNode ReverseList(ListNode head)
    {
        if (head is null || head.next is null) return head;

        ListNode reversed = null;
        var node = head;
        while (node != null)
        {
            var tempNext = node.next;
            node.next = reversed;
            reversed = node;
            node = tempNext;
        }
        return reversed;
    }
}