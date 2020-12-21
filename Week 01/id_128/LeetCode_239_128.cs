public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (k < 1 || k > nums.Length)
        {
            return new int[] { };
        }
        var result = new int[nums.Length - k + 1];
        var deque = new LinkedList<int>();

        for (int i = 0; i < k - 1; i++)
        {
            AddLast(deque, nums, i);
        }

        for (int i = k - 1; i < nums.Length; i++)
        {
            AddLast(deque, nums, i);
            result[i - k + 1] = nums[deque.First.Value];
            if (deque.First.Value <= i - k + 1)
                deque.RemoveFirst();
        }
        return result;
    }

    private void AddLast(LinkedList<int> deque, int[] nums, int i)
    {
        while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
            deque.RemoveLast();
        deque.AddLast(i);
    }
}
