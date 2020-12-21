/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */

// @lc code=start


//f[n] = nums[n] + max(0, f[n-1])
public class Solution {
    public int MaxSubArray(int[] nums) {
        if (nums.Length <= 0) return 0;
        if (nums.Length == 1) return nums[0];

        int subAns = nums[0];
        int opt = subAns;
        for (int i=0;i<nums.Length;i++) {
            subAns = nums[i] + Math.Max(0,subAns);
            opt = Math.Max(subAns, opt);
        }
        return opt;
    }
}
// @lc code=end

