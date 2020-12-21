/*
 * @lc app=leetcode id=300 lang=csharp
 *
 * [300] Longest Increasing Subsequence
 */

// @lc code=start
public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        int length = nums.Length;
        if (length < 2) return length;
        var dp = new int[length];
        for (int i = 0; i < length; i++) dp[i] = 1;

        var result = 0;
        for (int i = 1; i < length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] > nums[j])
                    dp[i] = Math.Max(dp[j] + 1, dp[i]);
            }
            result = Math.Max(result, dp[i]);
        }
        return result;
    }
}
// @lc code=end
//dp represents the lis length that ends with nums[i]
//dp[i] = Max(dp[i],dp[j]+1) where j in [0,i-1]
