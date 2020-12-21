public class MyCircularDeque
{

    private int[] internalList;
    private int len;
    private int begin = 0;
    private int end = 0;
    public MyCircularDeque(int k)
    {
        len = k + 1;
        internalList = new int[len];
    }

    public bool InsertFront(int value)
    {
        if (IsFull())
            return false;
        begin = (begin + len - 1) % len;
        internalList[begin] = value;
        return true;
    }

    public bool InsertLast(int value)
    {
        if (IsFull())
            return false;
        internalList[end] = value;
        end = (end + 1) % len;
        return true;
    }

    public bool DeleteFront()
    {
        if (IsEmpty())
            return false;
        begin = (begin + 1) % len;
        return true;
    }

    public bool DeleteLast()
    {
        if (IsEmpty())
            return false;
        end = (end + len - 1) % len;
        return true;
    }

    public int GetFront()
    {
        return IsEmpty() ? -1 : internalList[begin];
    }

    public int GetRear()
    {
        return IsEmpty() ? -1 : internalList[(end + len - 1) % len];
    }

    public bool IsEmpty()
    {
        return begin == end;
    }

    public bool IsFull()
    {
        return (end + 1) % len == begin;
    }
}


