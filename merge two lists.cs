L1 : 1-2-4, L2 : 1-3-5, result : 1-1-2-3-4-5


class LinkedListNode {
    int val;
    LinkedListNode next;
    public LinkedListNode()
    {
        val = -1;
        next = null;
    }
}


public LinkedListNode Merge(LinkedListNode l1, LinkedListNode l2) {

    var dummy = new LinkedListNode();
    var cur = dummy;
    while (l1 != null && l2 != null) {
        if (l1.val < l2.val) {
            cur.next = l1;
            l1 = l1.next;
        } else {
            cur.next = l2;
            l2 = l2.next;
        }
        cur = cur.next;
    }

    if (l1 is null) 
        cur.next = l2;
    else
        cur.next = l1;

    return dummy.next;
}