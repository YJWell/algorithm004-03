//pattern of circular queue implementation
//waste a space to distingusih Full and Empty
//end points to the first empty space
//begin points to the first occupied space
public class MyCircularQueue
{

    private int[] internalList;
    private int begin = 0;
    private int end = 0;
    private int len;
    public MyCircularQueue(int k)
    {
        len = k + 1;
        internalList = new int[len];
    }

    public bool EnQueue(int value)
    {
        if (!IsFull())
        {
            internalList[end] = value;
            end = (end + 1) % len;
            return true;
        }
        return false;
    }

    public bool DeQueue()
    {
        if (!IsEmpty())
        {
            begin = (begin + 1) % len;
            return true;
        }
        return false;
    }

    public int Front()
    {
        return IsEmpty() ? -1 : internalList[begin];
    }

    public int Rear()
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

