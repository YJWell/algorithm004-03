public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();
        if (nums.Length < 3) return result;
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] > 0) continue;
            if (i > 0 && nums[i - 1] == nums[i]) continue;
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[left] + nums[right] + nums[i];
                if (sum == 0)
                {
                    result.Add(new List<int>() { nums[i], nums[left], nums[right] });
                    right--; left++;
                    while (left < right && nums[right + 1] == nums[right]) right--;
                    while (left < right && nums[left - 1] == nums[left]) left++;

                }
                else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }
        return result;
    }
}