/*
 * @lc app=leetcode id=152 lang=csharp
 *
 * [152] Maximum Product Subarray
 */

// @lc code=start

public class Solution {
    public int MaxProduct(int[] nums) {
        if (nums.Length <=0) return 0;
        if (nums.Length ==1) return nums[0];

        var max = new int[nums.Length];
        var min = new int[nums.Length];
        min[0] = nums[0];
        max[0] = nums[0];
        for (int i = 1; i< nums.Length; i++)
        {
            min[i] =  Math.Min(max[i-1] * nums[i], Math.Min(min[i-1] * nums[i] , nums[i]));
            max[i] =  Math.Max(max[i-1] * nums[i], Math.Max(min[i-1] * nums[i] , nums[i]));
        }
        return max.Max();
    }
}
// @lc code=end

