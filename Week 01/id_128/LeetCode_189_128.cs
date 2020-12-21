//reverse
public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        //bounds checking
        if (nums.Length < 2)
            return;

        k = k % nums.Length;

        Reverse(nums, 0, nums.Length);
        Reverse(nums, 0, k);
        Reverse(nums, k, nums.Length - k);

    }

    private void Reverse(int[] nums, int start, int length)
    {
        int end = start + length - 1;
        int temp;
        while (start < end)
        {
            temp = nums[start];
            nums[start++] = nums[end];
            nums[end--] = temp;
        }
    }

}

//cyclic instituion
public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        if (nums.Length < 2) return;

        k = k % nums.Length;
        int count = 0;
        for (int start = 0; count < nums.Length; start++)
        {
            int curVal = nums[start];
            int curIdx = start;
            int nextVal = -1;
            int nextIdx = -1;
            while (start != nextIdx)
            {
                nextIdx = (curIdx + k) % nums.Length;
                nextVal = nums[nextIdx];
                nums[nextIdx] = curVal;
                curIdx = nextIdx;
                curVal = nextVal;
                count++;
            }
        }
    }
}