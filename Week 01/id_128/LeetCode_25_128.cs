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
    public ListNode ReverseKGroup(ListNode head, int k)
    {

        var dummy = new ListNode(-1);
        dummy.next = head;

        ListNode preTail = dummy;
        var cur = dummy;
        var count = 0;
        while (cur.next != null)
        {
            cur = cur.next;
            count++;

            if (count == k)
            {
                //var nextHead = cur.next;
                //var curKOriHead = preTail.next;
                //var curKOriTail = cur;
                //var curKReversedHead = cur;
                var curKReversedTail = preTail.next;
                preTail.next = Reverse(preTail.next, cur.next);
                preTail = curKReversedTail;
                cur = curKReversedTail;
                count = 0;
            }
        }

        return dummy.next;
    }



    private ListNode Reverse(ListNode head, ListNode unreversedHead)
    {
        ListNode pre = unreversedHead;
        ListNode next = null;
        var cur = head;
        while (cur != unreversedHead)
        {
            next = cur.next;
            cur.next = pre;
            pre = cur;
            cur = next;
        }

        return pre;
    }
}