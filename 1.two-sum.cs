/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
using System.Collections.Generic;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(target - nums[i]))
            {
                return new int[] { map[target - nums[i]], i };
            }
            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }
        }
    }
}
// @lc code=end

