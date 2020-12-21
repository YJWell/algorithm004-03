//open interval
public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        if (nums.Length < 1) return new int[] { -1, -1 };
        var start = LowerBoundSearch(nums, target);
        var end = UpperBoundSearch(nums, target);
        return new int[] { start, end };
    }

    private int UpperBoundSearch(int[] nums, int target)
    {
        var start = 0;
        var end = nums.Length;

        while (start < end)
        {
            var mid = start + (end - start) / 2;

            if (nums[mid] == target)
            {
                start = mid + 1;
            }
            else if (nums[mid] > target)
            {
                end = mid;
            }
            else if (nums[mid] < target)
            {
                start = mid + 1;
            }
        }
        if (start == 0) return -1;
        return nums[start - 1] == target ? start - 1 : -1;
    }

    private int LowerBoundSearch(int[] nums, int target)
    {
        var start = 0;
        var end = nums.Length;

        while (start < end)
        {
            var mid = start + (end - start) / 2;
            if (nums[mid] == target)
            {
                end = mid;
            }
            else if (nums[mid] > target)
            {
                end = mid;
            }
            else if (nums[mid] < target)
            {
                start = mid + 1;
            }

        }

        if (start == nums.Length) return -1;
        return nums[start] == target ? start : -1;

    }
}





//close interval
public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        if (nums.Length < 1) return new int[] { -1, -1 };
        var start = LowerBoundSearch(nums, target);
        var end = UpperBoundSearch(nums, target);
        return new int[] { start, end };
    }

    private int UpperBoundSearch(int[] nums, int target)
    {
        var start = 0;
        var end = nums.Length - 1;

        while (start <= end)
        {
            var mid = start + (end - start) / 2;

            if (nums[mid] == target)
            {
                start = mid + 1;
            }
            else if (nums[mid] > target)
            {
                end = mid - 1;
            }
            else if (nums[mid] < target)
            {
                start = mid + 1;
            }
        }
        if (end < 0) return -1;
        return nums[end] == target ? end : -1;
    }

    private int LowerBoundSearch(int[] nums, int target)
    {
        var start = 0;
        var end = nums.Length - 1;

        while (start <= end)
        {
            var mid = start + (end - start) / 2;
            if (nums[mid] == target)
            {
                end = mid - 1;
            }
            else if (nums[mid] > target)
            {
                end = mid - 1;
            }
            else if (nums[mid] < target)
            {
                start = mid + 1;
            }

        }

        if (start >= nums.Length) return -1;
        return nums[start] == target ? start : -1;

    }
}