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
    public ListNode DetectCycle(ListNode head)
    {
        var slow = head;
        var fast = head;
        bool intersect = false;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (fast == slow)
            {
                intersect = true;
                break;
            }
        }


        if (!intersect)
            return null;

        slow = head;

        while (slow != fast)
        {
            fast = fast.next;
            slow = slow.next;
        }
        return slow;

    }
}