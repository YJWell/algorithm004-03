//recursive
public class Solution
{

    private ListNode unReversedHead = null;
    public ListNode ReverseBetween(ListNode head, int m, int n)
    {

        if (m > 1)
        {
            head.next = ReverseBetween(head.next, m - 1, n - 1);
            return head;
        }
        else
        {
            if (n > 1)
            {
                var reversedHead = ReverseBetween(head.next, 1, n - 1);
                head.next.next = head;
                head.next = unReversedHead;
                return reversedHead;
            }
            else
            {
                unReversedHead = head.next;
                return head;
            }
        }

    }
}



//iteration
public class Solution
{

    public ListNode ReverseBetween(ListNode head, int m, int n)
    {
        if (head is null) return head;

        ListNode leadUnreversedLast = null;
        var cur = head;
        while (m > 1)
        {
            leadUnreversedLast = cur;
            cur = cur.next;
            m--; n--;
        }

        var reversedLastUnNull = cur;
        ListNode pre = null;
        ListNode next = null;
        for (; m <= n; m++)
        {
            next = cur.next;
            cur.next = pre;
            pre = cur;
            cur = next;
        }

        //var reversedHead = pre;
        //var trailUnreversedFirst = cur;

        reversedLastUnNull.next = cur;

        if (leadUnreversedLast is null)
            return pre;
        else
        {
            leadUnreversedLast.next = pre;
            return head;
        }

    }
}

