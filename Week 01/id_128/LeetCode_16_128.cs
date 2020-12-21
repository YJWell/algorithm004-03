public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {

        Array.Sort(nums);
        int minDistance = Int32.MaxValue;
        int ret = -1;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[left] + nums[right] + nums[i];
                int distance = Math.Abs(sum - target);
                if (distance == 0) return sum;
                if (distance < minDistance)
                {
                    minDistance = distance;
                    ret = sum;
                }
                else if (sum > target)
                    right--;
                else
                    left++;
            }
        }
        return ret;
    }
}